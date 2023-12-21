using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class StudentExamForm : Form
    {
        private int StudentID = 0;
        private int StudentExamID = 0;
        private StudentExamClass newStudentExam = new StudentExamClass();
        public StudentExamForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitStudentData()).Wait();
                Task.Run(() => InitExamList()).Wait();
                hlabelId.Text = "";
                listViewExamHistory.Items.Clear();
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:StudentExamForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitStudentData()
        {
            try
            {
                StudentClass student = new StudentClass();
                student = await StudentAPIClass.getStudent(0, GlobalValues.LoginUser.id);
                textBoxName.Text = student.studentname;
                StudentID = student.id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:InitStudentData", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitExamList()
        {
            try
            {
                List<ExamClass> list = new List<ExamClass>();
                list = await ExamAPIClass.getExams();
                listViewExams.Items.Clear();
                foreach (ExamClass exam in list)
                {
                    ListViewItem listItem = listViewExams.Items.Add(exam.examname);
                    listItem.Tag = exam.id;
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(exam.duration.ToString());
                    subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:InitExamList", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (hlabelId.Text.Length > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Preparing Exam Paper....", Color.LightGreen);
                    Task.Run(() => InitStudentExamData()).Wait();
                    Task.Run(() => InitExamQuestionData()).Wait();
                    TakeExamForm takeExamFormfrm = new TakeExamForm(newStudentExam, Int32.Parse(textBoxNoOfQuestions.Text), Int32.Parse(textBoxDuration.Text), Int32.Parse(textBoxPassingScore.Text), textBoxExamName.Text);
                    takeExamFormfrm.FormClosed += new FormClosedEventHandler(childFormClosed);
                    takeExamFormfrm.Show();
                    SetStatusMessage("", SystemColors.Control);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:buttonStart_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Fetching Exam Data....", Color.LightGreen);
                ExamClass exam = new ExamClass();
                string id = hlabelId.Text;
                exam = Task.Run(() => GetExamData(Int32.Parse(id))).Result;

                List<StudentExamClass> studentexams = new List<StudentExamClass>();
                studentexams = Task.Run(() => GetStudentExamData(Int32.Parse(id))).Result;
                listViewExamHistory.Items.Clear();
                if (studentexams != null)
                {
                    foreach (StudentExamClass studentexam in studentexams)
                    {
                        ListViewItem listItem = listViewExamHistory.Items.Add(studentexam.starttime.Substring(0, studentexam.starttime.IndexOf("T")));
                        listItem.Tag = studentexam.id;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem1 = listItem.SubItems.Add(studentexam.attemptno.ToString());
                        subItem1.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem2 = listItem.SubItems.Add(studentexam.examscore.ToString());
                        subItem2.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        string examresult = studentexam.examresult == "P" ? "Pass" : "Fail";
                        ListViewItem.ListViewSubItem subItem3 = listItem.SubItems.Add(examresult);
                        subItem3.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem4 = listItem.SubItems.Add(studentexam.no_of_answeredq.ToString());
                        subItem4.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem5 = listItem.SubItems.Add(studentexam.no_of_correctq.ToString());
                        subItem5.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                    }
                }

                Cursor = Cursors.Default;
                SetStatusMessage("", SystemColors.Control);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:childFormClosed", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitStudentExamData()
        {
            try
            {
                newStudentExam.studentid = StudentID;
                newStudentExam.examid = Int32.Parse(hlabelId.Text);
                newStudentExam.attemptno = listViewExamHistory.Items.Count + 1;
                newStudentExam.starttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newStudentExam.endtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                newStudentExam.examresult = "F";
                newStudentExam.examscore = 0;
                newStudentExam.no_of_answeredq = 0;
                newStudentExam.no_of_correctq = 0;
                APIStatus res = Task.Run(() => StudentExamAPIClass.postStudentExam(newStudentExam)).Result;
                StudentExamID = Int32.Parse(UtilClass.RegxMatch(@"\d+", res.Message));
                newStudentExam.id = StudentExamID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:InitStudentExamData", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitExamQuestionData()
        {
            try
            {
                List<ExamQuestionClass> examQuestions = new List<ExamQuestionClass>();
                examQuestions = await ExamQuestionAPIClass.getExamQuestion(0, Int32.Parse(hlabelId.Text));

                StudentAnswerClass studentanswer = new StudentAnswerClass();
                foreach (ExamQuestionClass examQuestion in examQuestions) 
                {
                    studentanswer.studentexamid = StudentExamID;
                    studentanswer.examquestionid = examQuestion.id;
                    studentanswer.response_result = "S";
                    studentanswer.question_response = "0";
                    APIStatus res = Task.Run(() => StudentAnswerAPIClass.postStudentAnswer(studentanswer)).Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:InitExamQuestionData", ex.Message.ToString());
                this.Close();
            }
        }
        private void listViewExams_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Fetching Exam Data....", Color.LightGreen);
                ExamClass exam = new ExamClass();
                textBoxExamName.Text = listViewExams.SelectedItems[0].Text;
                string id = listViewExams.SelectedItems[0].Tag.ToString();
                exam = Task.Run(() => GetExamData(Int32.Parse(id))).Result;
                hlabelId.Text = exam.id.ToString();

                List<StudentExamClass> studentexams = new List<StudentExamClass>();
                studentexams = Task.Run(() => GetStudentExamData(Int32.Parse(id))).Result;
                listViewExamHistory.Items.Clear();
                if (studentexams != null)
                {
                    foreach (StudentExamClass studentexam in studentexams)
                    {
                        ListViewItem listItem = listViewExamHistory.Items.Add(studentexam.starttime.Substring(0, studentexam.starttime.IndexOf("T")));
                        listItem.Tag = studentexam.id;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem1 = listItem.SubItems.Add(studentexam.attemptno.ToString());
                        subItem1.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem2 = listItem.SubItems.Add(studentexam.examscore.ToString());
                        subItem2.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        string examresult = studentexam.examresult == "P" ? "Pass" : "Fail";
                        ListViewItem.ListViewSubItem subItem3 = listItem.SubItems.Add(examresult);
                        subItem3.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem4 = listItem.SubItems.Add(studentexam.no_of_answeredq.ToString());
                        subItem4.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem5 = listItem.SubItems.Add(studentexam.no_of_correctq.ToString());
                        subItem5.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                    }
                }

                textBoxDuration.Text = exam.duration.ToString();
                textBoxNoOfQuestions.Text = exam.no_of_questions.ToString();
                textBoxTotalScore.Text = exam.totalscore.ToString();
                textBoxPassingScore.Text = exam.passingscore.ToString();

                Cursor = Cursors.Default;
                SetStatusMessage("", SystemColors.Control);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:listViewExams_Click", ex.Message.ToString());
                this.Close();
            }
        }
        private async Task<ExamClass> GetExamData(int id)
        {
            try
            {
                ExamClass exam = new ExamClass();
                exam = await ExamAPIClass.getExam(id);
                return exam;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:GetExamData", ex.Message.ToString());
                this.Close();
                return new ExamClass();
            }
        }
        private async Task<List<StudentExamClass>> GetStudentExamData(int examid)
        {
            try
            {
                List<StudentExamClass> studentexams = new List<StudentExamClass>();
                studentexams = await StudentExamAPIClass.getStudentExam(0, 0, examid);
                return studentexams;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentExamForm:GetStudentExamData", ex.Message.ToString());
                this.Close();
                return new List<StudentExamClass>();
            }
        }

        private void listViewExamHistory_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int questionid = Int32.Parse(listViewExamHistory.SelectedItems[0].Tag.ToString());
            int examid = Int32.Parse(hlabelId.Text);
            int noofquestions = Int32.Parse(textBoxNoOfQuestions.Text);
            ExamHistoryForm examhistoryForm = new ExamHistoryForm(examid, questionid, noofquestions);
            examhistoryForm.Show();
            Cursor = Cursors.Default;
        }
    }
}
