using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class UserAPIClass
    {
        public static async Task<List<UserClass>> getUsers()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("user");
                var result = await response.Content.ReadAsStringAsync();
                List<UserClass> values = JsonSerializer.Deserialize<List<UserClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("UserAPIClass:getUsers", ex.Message.ToString());
                return new List<UserClass>();
            }
        }
        public static async Task<UserClass> getUser(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("user/" + id);
                var result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new UserClass();
                }
                else
                {
                    UserClass values = JsonSerializer.Deserialize<UserClass>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("UserAPIClass:getUser", ex.Message.ToString());
                return new UserClass();
            }
        }

        public static async Task<APIStatus> putUser(List<UserClass> user)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("useraccount", user.ElementAt(0).useraccount);
                dict.Add("username", user.ElementAt(0).username);
                dict.Add("passcode", user.ElementAt(0).passcode);
                dict.Add("roleid", user.ElementAt(0).roleid);
                dict.Add("apikey", user.ElementAt(0).apikey);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("user/" + user.ElementAt(0).id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("UserAPIClass:putUser", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> postUser(List<UserClass> user)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("useraccount", user.ElementAt(0).useraccount);
                dict.Add("username", user.ElementAt(0).username);
                dict.Add("passcode", user.ElementAt(0).passcode);
                dict.Add("roleid", user.ElementAt(0).roleid);
                dict.Add("apikey", user.ElementAt(0).apikey);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("user", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("UserAPIClass:postUser", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> delUser(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("user/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("UserAPIClass:delUser", ex.Message.ToString());
                return new APIStatus();
            }
        }
    }

    public class UserClass
    {
        public int id { get; set; }
        public string useraccount { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string passcode { get; set; } = string.Empty;
        public int roleid { get; set; }
        public string apikey { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }

}
