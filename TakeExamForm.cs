using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class TakeExamForm : Form
    {
        private DateTime startTime;
        private System.Timers.Timer progressTimer = new System.Timers.Timer(1000);
        private List<ExamQuestionClass> examQuestions = new List<ExamQuestionClass>();
        private List<StudentAnswerClass> studentAnswers = new List<StudentAnswerClass>();
        private List<StudentAnswerClass> studentAnswersSkipped = new List<StudentAnswerClass>();
        private List<StudentAnswerClass> studentAnswersMarked = new List<StudentAnswerClass>();
        private StudentExamClass newStudentExam = new StudentExamClass();
        private int ExamID = 0;
        private int StudentExamID = 0;
        private int NoOfQuestions = 0;
        private int StudentID = 0;
        private int Idx = 1;
        private int SIdx = 1;
        private int MIdx = 1;
        private int Duration = 0;
        private int Passing_Score = 0;
        private string ExamName = string.Empty;
        public TakeExamForm(StudentExamClass studentexam, int noofquestions, int duration, int passing_Score, string examname)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                newStudentExam = studentexam;
                ExamID = newStudentExam.examid;
                StudentExamID = newStudentExam.id;
                NoOfQuestions = noofquestions;
                StudentID = newStudentExam.studentid;
                Passing_Score = passing_Score;
                ExamName = examname;
                TakeExamReviewFormReturnValue.reviewtype = "A";
                TakeExamReviewFormReturnValue.questionid = 0;
                Task.Run(() => InitExamQuestionList()).Wait();
                Task.Run(() => InitStudentAnswerList(StudentExamID)).Wait();
                if (studentAnswers.Count == 0)
                {
                    this.Close();
                }
                DisplayData(Idx);
                labelExamName.Text = ExamName;
                textBoxQuestion.Focus();
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("TakeExamForm:TakeExamForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitExamQuestionList()
        {
            try
            {
                examQuestions = await ExamQuestionAPIClass.getExamQuestion(0, ExamID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("TakeExamForm:InitExamQuestionList", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitStudentAnswerList(int studentexamid)
        {
            try
            {
                studentAnswers = await StudentAnswerAPIClass.getStudentAnswer(0, studentexamid, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("TakeExamForm:InitStudentAnswerList", ex.Message.ToString());
                this.Close();
            }
        }

        private void DisplayData(int idx)
        {
            SetStatusMessage("", SystemColors.Control);
            if (studentAnswers[Idx - 1].response_result.Equals("R"))
            {
                groupBoxQuestion.Text = "Question: " + idx + "/" + NoOfQuestions + " (Review)";
                groupBoxQuestion.ForeColor = Color.OrangeRed;
            }
            else
            {
                groupBoxQuestion.Text = "Question: " + idx + "/" + NoOfQuestions;
                groupBoxQuestion.ForeColor = SystemColors.ControlText;
            }
            textBoxQuestion.Text = examQuestions[idx - 1].question;
            textBoxAnswer1.Text = examQuestions[idx - 1].answer1;
            textBoxAnswer2.Text = examQuestions[idx - 1].answer2;
            textBoxAnswer3.Text = examQuestions[idx - 1].answer3;
            textBoxAnswer4.Text = examQuestions[idx - 1].answer4;
            string[] student_answers = studentAnswers[idx - 1].question_response.Split(",");
            checkBoxAnswer1.Checked = false;
            checkBoxAnswer2.Checked = false;
            checkBoxAnswer3.Checked = false;
            checkBoxAnswer4.Checked = false;
            radioButtonAnswer1.Checked = false;
            radioButtonAnswer2.Checked = false;
            radioButtonAnswer3.Checked = false;
            radioButtonAnswer4.Checked = false;

            if (examQuestions[idx - 1].answer_type.Equals("S"))
            {
                checkBoxAnswer1.Visible = false;
                checkBoxAnswer2.Visible = false;
                checkBoxAnswer3.Visible = false;
                checkBoxAnswer4.Visible = false;
                radioButtonAnswer1.Visible = true;
                radioButtonAnswer2.Visible = true;
                radioButtonAnswer3.Visible = true;
                radioButtonAnswer4.Visible = true;
                if (student_answers.Length > 0)
                {
                    SetRadioCheckBox("R", student_answers);
                }
            }
            else
            {
                checkBoxAnswer1.Visible = true;
                checkBoxAnswer2.Visible = true;
                checkBoxAnswer3.Visible = true;
                checkBoxAnswer4.Visible = true;
                radioButtonAnswer1.Visible = false;
                radioButtonAnswer2.Visible = false;
                radioButtonAnswer3.Visible = false;
                radioButtonAnswer4.Visible = false;
                if (student_answers.Length > 0)
                {
                    SetRadioCheckBox("C", student_answers);
                }
            }
        }

        private void SetRadioCheckBox(string radio_or_checkbox, string[] student_answers)
        {
            foreach (string student_answer in student_answers)
            {
                switch (student_answer)
                {
                    case "1":
                        if (radio_or_checkbox == "C")
                        {
                            checkBoxAnswer1.Checked = true;
                        }
                        else
                        {
                            radioButtonAnswer1.Checked = true;
                        }
                        break;
                    case "2":
                        if (radio_or_checkbox == "C")
                        {
                            checkBoxAnswer2.Checked = true;
                        }
                        else
                        {
                            radioButtonAnswer2.Checked = true;
                        }
                        break;
                    case "3":
                        if (radio_or_checkbox == "C")
                        {
                            checkBoxAnswer3.Checked = true;
                        }
                        else
                        {
                            radioButtonAnswer3.Checked = true;
                        }
                        break;
                    case "4":
                        if (radio_or_checkbox == "C")
                        {
                            checkBoxAnswer4.Checked = true;
                        }
                        else
                        {
                            radioButtonAnswer4.Checked = true;
                        }
                        break;
                }
            }
        }

        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinalizeExam_Click(object sender, EventArgs e)
        {
            TakeExamReviewForm takeExamReviewForm = new TakeExamReviewForm(studentAnswers, examQuestions);
            takeExamReviewForm.FormClosed += new FormClosedEventHandler(childFormClosed);
            takeExamReviewForm.Show();
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            if (TakeExamReviewFormReturnValue.reviewtype.Equals("C"))
            {
                Idx = TakeExamReviewFormReturnValue.questionid + 1;
                TakeExamReviewFormReturnValue.reviewtype = "A";
            }
            else if (TakeExamReviewFormReturnValue.reviewtype.Equals("A"))
            {
                Idx = 1;
            }
            else if (TakeExamReviewFormReturnValue.reviewtype.Equals("S"))
            {
                studentAnswersSkipped = studentAnswers.FindAll(a => a.response_result == "S");
                if (studentAnswersSkipped.Count <= 0)
                {
                    TakeExamReviewFormReturnValue.reviewtype = "A";
                }
                else
                {
                    SIdx = 1;
                    Idx = studentAnswers.FindIndex(a => a.id == studentAnswersSkipped[SIdx - 1].id);
                    Idx++;
                }
            }
            else if (TakeExamReviewFormReturnValue.reviewtype.Equals("R"))
            {
                studentAnswersMarked = studentAnswers.FindAll(a => a.response_result == "R");
                if (studentAnswersMarked.Count <= 0)
                {
                    TakeExamReviewFormReturnValue.reviewtype = "A";
                }
                else
                {
                    MIdx = 1;
                    Idx = studentAnswers.FindIndex(a => a.id == studentAnswersMarked[MIdx - 1].id);
                    Idx++;
                }
            }
            DisplayData(Idx);
        }

        private void progressTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan timeWorking = DateTime.Now.Subtract(this.startTime);

            this.labelTimer.Text = timeWorking.ToString(@"hh\:mm\:ss");
        }

        private void TakeExamForm_Shown(object sender, EventArgs e)
        {
            this.progressTimer.Elapsed += progressTimer_Elapsed;
            this.progressTimer.SynchronizingObject = this;
            this.startTime = DateTime.Now;
            this.progressTimer.Start();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Idx < examQuestions.Count)
            {
                if (TakeExamReviewFormReturnValue.reviewtype.Equals("A"))
                {
                    Idx++;
                }
                else if (TakeExamReviewFormReturnValue.reviewtype.Equals("S"))
                {
                    if (SIdx >= studentAnswersSkipped.Count)
                    {
                        SetStatusMessage("Last Skipped Question...", Color.LightGreen);
                        return;
                    }
                    else
                    {
                        SIdx++;
                        Idx = studentAnswers.FindIndex(a => a.id == studentAnswersSkipped[SIdx - 1].id);
                        Idx++;
                    }
                }
                else if (TakeExamReviewFormReturnValue.reviewtype.Equals("R"))
                {
                    if (MIdx >= studentAnswersMarked.Count)
                    {
                        SetStatusMessage("Last Review Question...", Color.LightGreen);
                        return;
                    }
                    else
                    {
                        MIdx++;
                        Idx = studentAnswers.FindIndex(a => a.id == studentAnswersMarked[MIdx - 1].id);
                        Idx++;
                    }
                }
                DisplayData(Idx);
            }
            else
            {
                SetStatusMessage("Last Question...", Color.LightGreen);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (Idx > 1)
            {
                if (TakeExamReviewFormReturnValue.reviewtype.Equals("A"))
                {
                    Idx--;
                }
                else if (TakeExamReviewFormReturnValue.reviewtype.Equals("S"))
                {
                    if (SIdx <= 1)
                    {
                        SetStatusMessage("First Skipped Question...", Color.LightGreen);
                        return;
                    }
                    else
                    {
                        SIdx--;
                        Idx = studentAnswers.FindIndex(a => a.id == studentAnswersSkipped[SIdx - 1].id);
                        Idx++;
                    }
                }
                else if (TakeExamReviewFormReturnValue.reviewtype.Equals("R"))
                {
                    if (MIdx <= 1)
                    {
                        SetStatusMessage("First Review Question...", Color.LightGreen);
                        return;
                    }
                    else
                    {
                        MIdx--;
                        Idx = studentAnswers.FindIndex(a => a.id == studentAnswersMarked[MIdx - 1].id);
                        Idx++;
                    }
                }
                DisplayData(Idx);
            }
            else
            {
                SetStatusMessage("First Question...", Color.LightGreen);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Updating Your Answer....", Color.LightGreen);
                string selected_answer = string.Empty;
                if (examQuestions[Idx - 1].answer_type.Equals("M"))
                {
                    selected_answer = checkBoxAnswer1.Checked ? "1," : "";
                    if (checkBoxAnswer2.Checked) { selected_answer = selected_answer + "2,"; }
                    if (checkBoxAnswer3.Checked) { selected_answer = selected_answer + "3,"; }
                    if (checkBoxAnswer4.Checked) { selected_answer = selected_answer + "4,"; }
                    selected_answer = selected_answer.Remove(selected_answer.Length - 1, 1);
                }
                else
                {
                    if (radioButtonAnswer1.Checked)
                    {
                        selected_answer = "1";
                    }
                    else if (radioButtonAnswer2.Checked)
                    {
                        selected_answer = "2";
                    }
                    else if (radioButtonAnswer3.Checked)
                    {
                        selected_answer = "3";
                    }
                    else if (radioButtonAnswer4.Checked)
                    {
                        selected_answer = "4";
                    }
                }

                if (selected_answer.Length <= 0)
                {
                    SetStatusMessage("You have not selected any Answer...", Color.LightGreen);
                    Cursor = Cursors.Default;
                    return;
                }
                StudentAnswerClass studentanswer = new StudentAnswerClass();
                studentanswer.id = studentAnswers[Idx - 1].id;
                studentanswer.studentexamid = studentAnswers[Idx - 1].studentexamid;
                studentanswer.examquestionid = studentAnswers[Idx - 1].examquestionid;
                studentanswer.question_response = selected_answer;
                studentanswer.response_result = "S";
                APIStatus res = Task.Run(() => StudentAnswerAPIClass.putStudentAnswer(studentanswer)).Result;

                studentAnswers[Idx - 1].response_result = "A";    // A for Answered
                studentAnswers[Idx - 1].question_response = selected_answer;

                SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:buttonSubmit_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            studentAnswers[Idx - 1].response_result = "R";   // R for Marked for Review
        }

        private void buttonSubmitExam_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Finalizing Your Submission....", Color.LightGreen);

                int id = 0;
                int no_of_answeredq = 0;
                int no_of_correctq = 0;
                int exam_score = 0;
                foreach (StudentAnswerClass studentanswer in studentAnswers) 
                {
                    if (studentanswer.question_response.Trim().Length > 0)
                    {
                        no_of_answeredq++;
                        if (studentanswer.question_response.Equals(examQuestions[id].correct_answer))
                        {
                            studentanswer.response_result = "C";
                            no_of_correctq++;
                            exam_score = exam_score + examQuestions[id].marks;
                        }
                        else
                        {
                            studentanswer.response_result = "W";
                        }
                    }
                    else
                    {
                        studentanswer.response_result = "S";
                    }
                    APIStatus res_studentanswer = Task.Run(() => StudentAnswerAPIClass.putStudentAnswer(studentanswer)).Result;
                    id++;
                }

                newStudentExam.endtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newStudentExam.examscore = exam_score;
                newStudentExam.no_of_answeredq = no_of_answeredq;
                newStudentExam.no_of_correctq = no_of_correctq;
                newStudentExam.examresult = exam_score >= Passing_Score ? "P" : "F";
                APIStatus res_studentexam = Task.Run(() => StudentExamAPIClass.putStudentExam(newStudentExam)).Result;

                SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                Cursor = Cursors.Default;
                string msg = string.Empty;
                if (newStudentExam.examresult.Equals("P"))
                {
                    msg = "Your Exam Result: Pass";
                }
                else
                {
                    msg = "Your Exam Result: Fail";
                }
                if (DialogResult.OK == MessageBox.Show(msg,"Result", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("TakeExamForm:buttonSubmitExam_Click", ex.Message.ToString());
                this.Close();
            }
        }
    }
    public static class TakeExamReviewFormReturnValue
    {
        public static int questionid { get; set; }
        public static string reviewtype { get; set; } = string.Empty;
    }
}
