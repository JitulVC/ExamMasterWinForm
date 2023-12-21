using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExamMaster
{
    public partial class SetExamForm : Form
    {
        public SetExamForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitExamList()).Wait();
                buttonClear_Click(Owner, new EventArgs());
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("SetExamForm:SetExamForm", ex.Message.ToString());
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
                    ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(exam.rec_lastupdatedon.Substring(0, exam.rec_lastupdatedon.IndexOf("T")));
                    subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("SetExamForm:InitExamList", ex.Message.ToString());
                this.Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewExamQuestions_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int questionid = Int32.Parse(listViewExamQuestions.SelectedItems[0].Tag.ToString());
            int examid = Int32.Parse(hlabelId.Text);
            int qno = Int32.Parse(listViewExamQuestions.SelectedItems[0].SubItems[0].Text.ToString());
            int marks = 0;
            int noofquestions = Int32.Parse(textBoxNoOfQuestions.Text);
            QuestionForm questionForm = new QuestionForm(questionid, examid, qno, marks, noofquestions);
            questionForm.FormClosed += new FormClosedEventHandler(questionFormClosed);
            questionForm.Show();
            Cursor = Cursors.Default;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (hlabelId.Text != String.Empty)
                    {
                        Cursor = Cursors.WaitCursor;
                        SetStatusMessage("Deleting Exam Data....", Color.LightGreen);
                        APIStatus res1 = Task.Run(() => ExamQuestionAPIClass.delExamQuestion(0,Int32.Parse(hlabelId.Text))).Result;
                        APIStatus res2 = Task.Run(() => ExamAPIClass.delExam(Int32.Parse(hlabelId.Text))).Result;
                        listViewExams.SelectedItems[0].Remove();
                        buttonClear_Click(sender, e);
                        SetStatusMessage("Exam Data Deleted Successfully....", Color.LimeGreen);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("SetExamForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoOfQuestions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTotalScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPassingScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating Exam Data....", Color.LightGreen);
                    ExamClass exam = new ExamClass();
                    exam.id = hlabelId.Text.Trim() == "" ? 0 : Int32.Parse(hlabelId.Text);
                    exam.examname = textBoxExamName.Text;
                    exam.duration = Int32.Parse(textBoxDuration.Text);
                    exam.no_of_questions = Int32.Parse(textBoxNoOfQuestions.Text);
                    exam.totalscore = Int32.Parse(textBoxTotalScore.Text);
                    exam.passingscore = Int32.Parse(textBoxPassingScore.Text);
                    if (exam.id > 0)
                    {
                        APIStatus res = Task.Run(() => ExamAPIClass.putExam(exam)).Result;
                        listViewExams.SelectedItems[0].SubItems[1].Text = DateTime.Now.ToString("yyyy-mm-dd");
                    }
                    else
                    {
                        APIStatus res = Task.Run(() => ExamAPIClass.postExam(exam)).Result;
                        hlabelId.Text = UtilClass.RegxMatch(@"\d+", res.Message);
                        ListViewItem listItem = listViewExams.Items.Add(exam.examname);
                        listItem.Tag = hlabelId.Text;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(DateTime.Now.ToString("yyyy-mm-dd"));
                        subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        listViewExams.SelectedItems.Clear();
                        listViewExams.Items[listViewExams.Items.Count - 1].Selected = true;
                    }
                    SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("SetExamForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool ValidateData()
        {
            if (textBoxExamName.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("Exam Name Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (textBoxDuration.Text.Trim().Length <= 0)
            {
                SetStatusMessage("Duration Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (textBoxNoOfQuestions.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("No. of Quesions Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (textBoxTotalScore.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("Total Score Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (textBoxPassingScore.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("Passing Score Data Missing....", Color.LemonChiffon);
                return false;
            }
            return true;
        }
        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxExamName.Text = string.Empty;
            textBoxDuration.Text = string.Empty;
            textBoxNoOfQuestions.Text = string.Empty;
            textBoxTotalScore.Text = string.Empty;
            textBoxPassingScore.Text = string.Empty;
            listViewExamQuestions.Items.Clear();
            hlabelId.Text = string.Empty;
            SetStatusMessage("", SystemColors.Control);
        }

        private void listViewExams_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Fetching Exam Data....", Color.LightGreen);
                ExamClass exam = new ExamClass();
                string id = listViewExams.SelectedItems[0].Tag.ToString();
                exam = Task.Run(() => GetExamData(Int32.Parse(id))).Result;
                hlabelId.Text = exam.id.ToString();

                List<ExamQuestionClass> questions = new List<ExamQuestionClass>();
                questions = Task.Run(() => GetQuestionData(Int32.Parse(id))).Result;
                listViewExamQuestions.Items.Clear();
                if (questions != null)
                {
                    int qno = 0;
                    foreach (ExamQuestionClass question in questions)
                    {
                        qno++;
                        ListViewItem listItem = listViewExamQuestions.Items.Add(qno.ToString());
                        listItem.Tag = question.id;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(question.question);
                        subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                    }
                }

                textBoxExamName.Text = exam.examname;
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
                UtilClass.WriteLogs("SetExamForm:listViewExams_Click", ex.Message.ToString());
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
                UtilClass.WriteLogs("SetExamForm:GetExamData", ex.Message.ToString());
                this.Close();
                return new ExamClass();
            }
        }
        private async Task<List<ExamQuestionClass>> GetQuestionData(int examid)
        {
            try
            {
                List<ExamQuestionClass> questions = new List<ExamQuestionClass>();
                questions = await ExamQuestionAPIClass.getExamQuestion(0, examid);
                return questions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("SetExamForm:GetQuestionData", ex.Message.ToString());
                this.Close();
                return new List<ExamQuestionClass>();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (hlabelId.Text != String.Empty)
            {
                Cursor = Cursors.WaitCursor;
                int examId = Int32.Parse(hlabelId.Text);
                int qno = listViewExamQuestions.Items.Count + 1;
                int questionid = 0;
                int marks = Int32.Parse(textBoxTotalScore.Text) / Int32.Parse(textBoxNoOfQuestions.Text);
                int noofquestions = Int32.Parse(textBoxNoOfQuestions.Text);
                QuestionForm questionForm = new QuestionForm(questionid, examId, qno, marks, noofquestions);
                questionForm.FormClosed += new FormClosedEventHandler(questionFormClosed);
                questionForm.Show();
                Cursor = Cursors.Default;
            }
        }
        private void questionFormClosed(object sender, FormClosedEventArgs e)
        {
            if (returnQuestionValues.recstatus == "I")
            {
                ListViewItem listItem = listViewExamQuestions.Items.Add(returnQuestionValues.qno.ToString());
                listItem.Tag = returnQuestionValues.id;
                listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(returnQuestionValues.question);
                subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                listViewExamQuestions.SelectedItems.Clear();
                listViewExamQuestions.Items[listViewExamQuestions.Items.Count - 1].Selected = true;
            }
            else if (returnQuestionValues.recstatus == "U")
            {
                listViewExamQuestions.SelectedItems[0].SubItems[1].Text = returnQuestionValues.question;
            }
            else if (returnQuestionValues.recstatus == "D")
            {
                int selidx = listViewExamQuestions.SelectedItems[0].Index;
                if (selidx != listViewExamQuestions.Items.Count - 1)
                {
                    listViewExamQuestions.SelectedItems[0].Remove();
                    for (int i = selidx;i< listViewExamQuestions.Items.Count;i++) 
                    {
                        listViewExamQuestions.Items[i].Text = (Int32.Parse(listViewExamQuestions.Items[i].Text) - 1).ToString();                             
                    }
                }
                else
                {
                    listViewExamQuestions.SelectedItems[0].Remove();
                }
            }
        }
    }

    public class QuestionClass
    {
        public int id { get; set; }
        public int qno { get;set; }
        public string question { get; set; } = string.Empty;
        public QuestionClass()
        {
        }
        public QuestionClass(int _id, int _qno, string _question)
        {
            id = _id;
            qno = _qno;
            question = _question;
        }
    }

    public static class returnQuestionValues
    {
        public static int id { get; set; }
        public static int qno { get; set; }
        public static string question { get; set; } = string.Empty;
        public static string recstatus { get; set; } = string.Empty;
    }
}
