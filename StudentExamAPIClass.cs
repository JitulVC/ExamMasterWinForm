using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class StudentExamAPIClass
    {
        public static async Task<List<StudentExamClass>> getStudentExams()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("studentexam");
                var result = await response.Content.ReadAsStringAsync();
                List<StudentExamClass> values = JsonSerializer.Deserialize<List<StudentExamClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentExamAPIClass:getStudentExams", ex.Message.ToString());
                return new List<StudentExamClass>();
            }
        }
        public static async Task<List<StudentExamClass>> getStudentExam(int id, int studentid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("studentexam/" + id + "/" + studentid);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new List<StudentExamClass>();
                }
                else
                {
                    List<StudentExamClass> values = JsonSerializer.Deserialize<List<StudentExamClass>>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentExamAPIClass:getStudentExam", ex.Message.ToString());
                return new List<StudentExamClass>();
            }
        }
        public static async Task<APIStatus> putStudentExam(StudentExamClass studentexam)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentid", studentexam.studentid);
                dict.Add("examid", studentexam.examid);
                dict.Add("attemptno", studentexam.attemptno);
                dict.Add("examscore", studentexam.examscore);
                dict.Add("starttime", studentexam.starttime);
                dict.Add("endtime", studentexam.endtime);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("studentexam/" + studentexam.id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentExamAPIClass:putStudentExam", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postStudentExam(StudentExamClass studentexam)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentid", studentexam.studentid);
                dict.Add("examid", studentexam.examid);
                dict.Add("attemptno", studentexam.attemptno);
                dict.Add("examscore", studentexam.examscore);
                dict.Add("starttime", studentexam.starttime);
                dict.Add("endtime", studentexam.endtime);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("studentexam", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentExamAPIClass:postStudentExam", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delStudentExam(int id, int studentid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);
                var response = await httpClient.DeleteAsync("studentexam/" + id + "/" + studentid);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentExamAPIClass:delStudentExam", ex.Message.ToString());
                return new APIStatus();
            }
        }

    }
    public class StudentExamClass
    {
        public int id { get; set; }
        public int studentid { get; set; }
        public int examid { get; set; }
        public int attemptno { get; set; }
        public int examscore { get; set; }
        public string starttime { get; set; } = string.Empty;
        public string endtime { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
