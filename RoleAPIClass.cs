using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class RoleAPIClass
    {
        public static async Task<List<RoleClass>> getRoles()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("role");
                var result = await response.Content.ReadAsStringAsync();
                List<RoleClass> values = JsonSerializer.Deserialize<List<RoleClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RoleAPIClass:getRoles", ex.Message.ToString());
                return new List<RoleClass>();
            }
        }

        public static async Task<RoleClass> getRole(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("role/" + id);
                var result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new RoleClass();
                }
                else
                {
                    RoleClass values = JsonSerializer.Deserialize<RoleClass>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RoleAPIClass:getRole", ex.Message.ToString());
                return new RoleClass();
            }
        }

        public static async Task<APIStatus> putRole(List<RoleClass> role)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, string>();
                dict.Add("role", role.ElementAt(0).role);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("role/" + role.ElementAt(0).id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RoleAPIClass:putRole", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> postRole(List<RoleClass> role)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, string>();
                dict.Add("role", role.ElementAt(0).role);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("role", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RoleAPIClass:postRole", ex.Message.ToString());
                return new APIStatus();
            }
        }

        public static async Task<APIStatus> delRole(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("role/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RoleAPIClass:delRole", ex.Message.ToString());
                return new APIStatus();
            }
        }
    }

    public class RoleClass
    {
        public int id { get; set; }
        public string role { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }

}
