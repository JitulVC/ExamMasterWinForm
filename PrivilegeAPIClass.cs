using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class PrivilegeAPIClass
    {
        public static async Task<List<PrivilegeClass>> getPrivileges()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("privilege");
                var result = await response.Content.ReadAsStringAsync();
                List<PrivilegeClass> values = JsonSerializer.Deserialize<List<PrivilegeClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("PrivilegeAPIClass:getPrivileges", ex.Message.ToString());
                return new List<PrivilegeClass>();
            }
        }

        public static async Task<PrivilegeClass> getPrivilege(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("privilege/" + id);
                var result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new PrivilegeClass();
                }
                else
                {
                    PrivilegeClass values = JsonSerializer.Deserialize<PrivilegeClass>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("PrivilegeAPIClass:getPrivilege", ex.Message.ToString());
                return new PrivilegeClass();
            }
        }

        public static async Task<APIStatus> putPrivilege(List<PrivilegeClass> privilege)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, string>();
                dict.Add("privileges", privilege.ElementAt(0).privileges);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("privilege/" + privilege.ElementAt(0).id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("PrivilegeAPIClass:putPrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> postPrivilege(List<PrivilegeClass> privilege)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, string>();
                dict.Add("privileges", privilege.ElementAt(0).privileges);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("privilege", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("PrivilegeAPIClass:postPrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> delPrivilege(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("privilege/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("PrivilegeAPIClass:delPrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }
    }
    public class PrivilegeClass
    {
        public int id { get; set; }
        public string privileges { get; set; } = string.Empty;  
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
