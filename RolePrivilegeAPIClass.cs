using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class RolePrivilegeAPIClass
    {
        public static async Task<List<RolePrivilegeClass>> getRolePrivileges()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("roleprivilege");
                var result = await response.Content.ReadAsStringAsync();
                List<RolePrivilegeClass> values = JsonSerializer.Deserialize<List<RolePrivilegeClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RolePrivilegeAPIClass:getRolePrivileges", ex.Message.ToString());
                return new List<RolePrivilegeClass>();
            }
        }
        public static async Task<List<RolePrivilegeClass>> getRolePrivilege(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("roleprivilege/" + id);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new List<RolePrivilegeClass>();
                }
                else
                {
                    List<RolePrivilegeClass> values = JsonSerializer.Deserialize<List<RolePrivilegeClass>>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RolePrivilegeAPIClass:getRolePrivilege", ex.Message.ToString());
                return new List<RolePrivilegeClass>();
            }
        }
        public static async Task<APIStatus> putRolePrivilege(List<RolePrivilegeClass> roleprivilege)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, int>();
                dict.Add("roleid", roleprivilege.ElementAt(0).roleid);
                dict.Add("roleid", roleprivilege.ElementAt(0).privilegeid);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("roleprivilege/" + roleprivilege.ElementAt(0).id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RolePrivilegeAPIClass:putRolePrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postRolePrivilege(List<RolePrivilegeClass> roleprivilege)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, int>();
                dict.Add("roleid", roleprivilege.ElementAt(0).roleid);
                dict.Add("privilegeid", roleprivilege.ElementAt(0).privilegeid);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("roleprivilege", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RolePrivilegeAPIClass:postRolePrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delRolePrivilege(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("roleprivilege/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("RolePrivilegeAPIClass:delRolePrivilege", ex.Message.ToString());
                return new APIStatus();
            }
        }
    }
    public class RolePrivilegeClass
    {
        public int id { get; set; }
        public int roleid { get; set; }
        public int privilegeid { get; set; }
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
