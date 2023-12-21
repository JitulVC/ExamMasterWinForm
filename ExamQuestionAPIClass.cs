using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamMaster
{
    internal class ExamQuestionAPIClass
    {
        public static async Task<List<ExamQuestionClass>> getExamQuestions()
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("examquestion");
                var result = await response.Content.ReadAsStringAsync();
                List<ExamQuestionClass> values = JsonSerializer.Deserialize<List<ExamQuestionClass>>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamQuestionAPIClass:getExamQuestions", ex.Message.ToString());
                return new List<ExamQuestionClass>();
            }
        }
        public static async Task<List<ExamQuestionClass>> getExamQuestion(int id, int examid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var response = await httpClient.GetAsync("examquestion/" + id + "/" + examid);
                string result = await response.Content.ReadAsStringAsync();
                if (result.Contains("Item not found"))
                {
                    return new List<ExamQuestionClass>();
                }
                else
                {
                    if (id > 0)
                    {
                        result = "[" + result + "]";
                    }
                    List<ExamQuestionClass> values = JsonSerializer.Deserialize<List<ExamQuestionClass>>(result);
                    return values;
                }
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamQuestionAPIClass:getExamQuestion", ex.Message.ToString());
                return new List<ExamQuestionClass>();
            }
        }
        public static async Task<APIStatus> putExamQuestion(ExamQuestionClass examquestion)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("examid", examquestion.examid);
                dict.Add("question", examquestion.question);
                dict.Add("answer_type", examquestion.answer_type);
                dict.Add("answer1", examquestion.answer1);
                dict.Add("answer2", examquestion.answer2);
                dict.Add("answer3", examquestion.answer3);
                dict.Add("answer4", examquestion.answer4);
                dict.Add("marks", examquestion.marks);
                dict.Add("correct_answer", examquestion.correct_answer);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("examquestion/" + examquestion.id + "/0", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamQuestionAPIClass:putExamQuestion", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> postExamQuestion(ExamQuestionClass examquestion)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);

                var dict = new Dictionary<string, object>();
                dict.Add("examid", examquestion.examid);
                dict.Add("question", examquestion.question);
                dict.Add("answer_type", examquestion.answer_type);
                dict.Add("answer1", examquestion.answer1);
                dict.Add("answer2", examquestion.answer2);
                dict.Add("answer3", examquestion.answer3);
                dict.Add("answer4", examquestion.answer4);
                dict.Add("marks", examquestion.marks);
                dict.Add("correct_answer", examquestion.correct_answer);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("examquestion", data);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);
                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamQuestionAPIClass:postExamQuestion", ex.Message.ToString());
                return new APIStatus();
            }
        }
        public static async Task<APIStatus> delExamQuestion(int id, int examid)
        {
            try
            {
                await UtilClass.ValidateToken();
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);
               
                var response = await httpClient.DeleteAsync("examquestion/" + id + "/" + examid);
                var result = await response.Content.ReadAsStringAsync();
                APIStatus values = JsonSerializer.Deserialize<APIStatus>(result);

                return values;
            }
            catch (Exception ex)
            {
                UtilClass.WriteLogs("ExamQuestionAPIClass:delExamQuestion", ex.Message.ToString());
                return new APIStatus();
            }
        }

    }
    public class ExamQuestionClass
    {
        public int id { get; set; }
        public int examid { get; set; }
        public string question { get; set; } = string.Empty;
        public string answer_type { get; set; } = string.Empty;
        public string answer1 { get; set; } = string.Empty;
        public string answer2 { get; set; } = string.Empty;
        public string answer3 { get; set; } = string.Empty;
        public string answer4 { get; set; } = string.Empty;
        public int marks { get; set; }
        public string correct_answer { get; set; } = string.Empty;
        public string rec_insertedon { get; set; } = string.Empty;
        public string rec_lastupdatedon { get; set; } = string.Empty;
    }
}
