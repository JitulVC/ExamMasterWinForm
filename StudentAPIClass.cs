using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class StudentAPIClass
    {
        public static async Task<List<StudentClass>> getStudents()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("student");
                var result = await response.Content.ReadAsStringAsync();
                List<StudentClass> values = JsonSerializer.Deserialize<List<StudentClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAPIClass:getStudents", ex.Message.ToString());
                return new List<StudentClass>();
            }
        }
        public static async Task<StudentClass> getStudent(int id, int userid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("student/" + id + "/" + userid);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new StudentClass();
                }
                else
                {
                    StudentClass values = JsonSerializer.Deserialize<StudentClass>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAPIClass:getStudent", ex.Message.ToString());
                return new StudentClass();
            }
        }
        public static async Task<APIStatus> putStudent(StudentClass student)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentname", student.studentname);
                dict.Add("userid", student.userid);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("student/" + student.id + "/0", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAPIClass:putStudent", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postStudent(StudentClass student)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentname", student.studentname);
                dict.Add("userid", student.userid);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("student", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAPIClass:postStudent", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delStudent(int id, int userid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("student/" + id + "/" + userid);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAPIClass:delStudent", ex.Message.ToString());
                return new APIStatus();
            }
        }

    }
    public class StudentClass
    {
        public int id { get; set; }
        public string studentname { get; set; } = string.Empty;
        public int userid { get; set; }
        public string lastlogin { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
