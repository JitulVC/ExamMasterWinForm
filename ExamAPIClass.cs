using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class ExamAPIClass
    {
        public static async Task<List<ExamClass>> getExams()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("exam");
                var result = await response.Content.ReadAsStringAsync();
                List<ExamClass> values = JsonSerializer.Deserialize<List<ExamClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamAPIClass:getExams", ex.Message.ToString());
                return new List<ExamClass>();
            }
        }
        public static async Task<ExamClass> getExam(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("exam/" + id);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new ExamClass();
                }
                else
                {
                    ExamClass values = JsonSerializer.Deserialize<ExamClass>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamAPIClass:getExam", ex.Message.ToString());
                return new ExamClass();
            }
        }
        public static async Task<APIStatus> putExam(ExamClass exam)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("examname", exam.examname);
                dict.Add("no_of_questions", exam.no_of_questions);
                dict.Add("duration", exam.duration);
                dict.Add("totalscore", exam.totalscore);
                dict.Add("passingscore", exam.passingscore);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("exam/" + exam.id, data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamAPIClass:putExam", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postExam(ExamClass exam)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("examname", exam.examname);
                dict.Add("no_of_questions", exam.no_of_questions);
                dict.Add("duration", exam.duration);
                dict.Add("totalscore", exam.totalscore);
                dict.Add("passingscore", exam.passingscore);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("exam", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamAPIClass:postExam", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delExam(int id)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.DeleteAsync("exam/" + id);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamAPIClass:delExam", ex.Message.ToString());
                return new APIStatus();
            }
        }

    }
    public class ExamClass
    {
        public int id { get; set; }
        public string examname { get; set; } = string.Empty;
        public int no_of_questions { get; set; }
        public int duration { get; set; }
        public int totalscore { get; set; }
        public int passingscore { get; set; }
        public int difficulty_level { get; set; }
        public int subjectid { get; set; }
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
