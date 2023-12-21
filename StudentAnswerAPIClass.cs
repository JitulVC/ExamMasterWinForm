using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class StudentAnswerAPIClass
    {
        public static async Task<List<StudentAnswerClass>> getStudentAnswers()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("studentanswer");
                var result = await response.Content.ReadAsStringAsync();
                List<StudentAnswerClass> values = JsonSerializer.Deserialize<List<StudentAnswerClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAnswerAPIClass:getStudentAnswers", ex.Message.ToString());
                return new List<StudentAnswerClass>();
            }
        }
        public static async Task<List<StudentAnswerClass>> getStudentAnswer(int id, int studentexamid, int examquestionid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("studentanswer/" + id + "/" + studentexamid + "/" + examquestionid);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new List<StudentAnswerClass>();
                }
                else
                {
                    List<StudentAnswerClass> values = JsonSerializer.Deserialize<List<StudentAnswerClass>>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAnswerAPIClass:getStudentAnswer", ex.Message.ToString());
                return new List<StudentAnswerClass>();
            }
        }
        public static async Task<APIStatus> putStudentAnswer(StudentAnswerClass studentanswer)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentexamid", studentanswer.studentexamid);
                dict.Add("examquestionid", studentanswer.examquestionid);
                dict.Add("question_response", studentanswer.question_response);
                dict.Add("response_result", studentanswer.response_result);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("studentanswer/" + studentanswer.id + "/" + studentanswer.studentexamid + "/" + studentanswer.examquestionid, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAnswerAPIClass:putStudentAnswer", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postStudentAnswer(StudentAnswerClass studentanswer)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("studentexamid", studentanswer.studentexamid);
                dict.Add("examquestionid", studentanswer.examquestionid);
                dict.Add("question_response", studentanswer.question_response);
                dict.Add("response_result", studentanswer.response_result);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("studentanswer", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAnswerAPIClass:postStudentAnswer", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delStudentAnswer(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);
                var response = await httpClient.DeleteAsync("studentanswer/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("StudentAnswerAPIClass:delStudentAnswer", ex.Message.ToString());
                return new APIStatus();
            }
        }

    }
    public class StudentAnswerClass
    {
        public int id { get; set; }
        public int studentexamid { get; set; }
        public int examquestionid { get; set; }
        public string question_response { get; set; } = string.Empty;
        public string response_result { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
