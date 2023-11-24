using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ExamMaster
{
    internal class UtilClass
    {
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        
        public static void ReadConfig()
        {
            string? apiURL = System.Configuration.ConfigurationManager.AppSettings.Get("APIUrl");
            string? apiUserAccount = System.Configuration.ConfigurationManager.AppSettings.Get("APIUser");
            string? apiPasscode = System.Configuration.ConfigurationManager.AppSettings.Get("APIPasscode");
            string? apiKey = System.Configuration.ConfigurationManager.AppSettings.Get("APIKey");

            apiPasscode = apiPasscode ?? string.Empty;
            apiKey= apiKey ?? string.Empty;
            apiPasscode = UtilClass.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", apiPasscode);
            apiKey = UtilClass.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", apiKey);

            GlobalValues.APIUrl = apiURL;
            GlobalValues.APIUserAccount = apiUserAccount;
            GlobalValues.APIPasscode = apiPasscode;
            GlobalValues.APIKey = apiKey;
        }
        public static async Task<Dictionary<string, string>> GetSessionKey()
        {
            ReadConfig();

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
            var dict = new Dictionary<string, string>();
            dict.Add("useraccount", GlobalValues.APIUserAccount);
            dict.Add("passcode", GlobalValues.APIPasscode);
            dict.Add("apikey", GlobalValues.APIKey);
            var json = JsonSerializer.Serialize(dict);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("token", data);
            var result = await response.Content.ReadAsStringAsync();
            var values = JsonSerializer.Deserialize<Dictionary<string, string>>(result);
            return values;
        }

        public static async Task<Dictionary<string, string>> RefreshSessionKey()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIRefreshToken);

            var response = await httpClient.PostAsync("token/refresh",null);
            var result = await response.Content.ReadAsStringAsync();
            var values = JsonSerializer.Deserialize<Dictionary<string, string>>(result);
            return values;
        }

        public static void WriteLogs(string moduleName,string errMsg)
        {
            string logPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString();
            string logFileName = logPath + @"\ExamMasterLog" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            using (StreamWriter sw = File.AppendText(logFileName))
            {
                sw.WriteLine(DateTime.Now.ToString()+","+moduleName+","+ errMsg);
            }
        }

        public static async Task ValidateToken()
        {
            DateTime TokenValidity = GetToeknExpiry(GlobalValues.APIToken);
            if (TokenValidity < DateTime.Now)
            {
                DateTime RefreshTokenValidity = GetToeknExpiry(GlobalValues.APIRefreshToken);
                if (RefreshTokenValidity > DateTime.Now)
                {
                    Dictionary<string, string> keyValuePairs = await UtilClass.RefreshSessionKey();
                    GlobalValues.APIToken = keyValuePairs.ElementAt(0).Value;
                }
                else
                {
                    Dictionary<string, string> keyValuePairs = await UtilClass.GetSessionKey();
                    GlobalValues.APIToken = keyValuePairs.ElementAt(0).Value;
                    GlobalValues.APIRefreshToken = keyValuePairs.ElementAt(1).Value;
                }
            }
        }
        public static DateTime GetToeknExpiry(string accessToken)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(accessToken))
                    return DateTime.MinValue;
                if (!accessToken.Contains("."))
                    return DateTime.MinValue;

                string[] parts = accessToken.Split('.');
                JwtToken payload = JsonSerializer.Deserialize<JwtToken>(Base64UrlEncoder.Decode(parts[1]));
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(payload.exp);
                return dateTimeOffset.LocalDateTime;
            }
            catch (Exception ex)
            {
                WriteLogs("UtilClass", ex.Message.ToString());
                return DateTime.MinValue;
            }
        }

        public static string RegxMatch(string pattern, string text)
        {
            try
            {
                Regex rgx = new Regex(pattern);
                Match matchedText = rgx.Match(text);
                return matchedText.Value;
            }
            catch (Exception ex)
            {
                WriteLogs("UtilClass", ex.Message.ToString());
                return string.Empty;
            }
        }
    }
    public class JwtToken
    {
        public long exp { get; set; }
    }

    public class APIStatus
    {
        public string message { get; set; } = string.Empty;
        public int HTTPStatus { get; set; }
    }
}
