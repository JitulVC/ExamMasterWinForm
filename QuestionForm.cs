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
    public partial class QuestionForm : Form
    {
        private int QuestionId = 0;
        private int ExamId = 0;
        private int QNo = 0;
        private int Marks = 0;
        private int NoOfQuestions = 0;
        public QuestionForm(int questionid, int examid, int qno, int marks, int noofquesions)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                QuestionId = questionid;
                ExamId = examid;
                QNo = qno;
                Marks = marks;
                NoOfQuestions = noofquesions;
                groupBoxQuestion.Text = "Question No.: " + QNo + "/" + NoOfQuestions;
                textBoxMarks.Text = Marks.ToString();
                if (QuestionId > 0)
                {
                    SetStatusMessage("Fetching Data....", Color.LightGreen);
                    Task.Run(() => InitQuestion()).Wait();
                }
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("QuestionForm:QuestionForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitQuestion()
        {
            try
            {
                List<ExamQuestionClass>  question = new List<ExamQuestionClass>();
                question = await ExamQuestionAPIClass.getExamQuestion(QuestionId,0);
                textBoxQuestion.Text = question[0].question;
                textBoxQuestion.Focus();
                if (question[0].answer_type.Equals("S"))
                {
                    radioButtonSingleChoice.Checked = true;
                }
                else
                {
                    radioButtonMultiChoice.Checked = true;
                }
                textBoxMarks.Text = question[0].marks.ToString();
                textBoxAnswer1.Text = question[0].answer1;
                textBoxAnswer2.Text = question[0].answer2;
                textBoxAnswer3.Text = question[0].answer3;
                textBoxAnswer4.Text = question[0].answer4;
                string[] correct_answers = question[0].correct_answer.Split(',');
                foreach (string correct_answer in correct_answers)
                {
                    switch(correct_answer)
                    {
                        case "1":
                            checkBoxAnswer1.Checked = true; break;
                        case "2":
                            checkBoxAnswer2.Checked = true; break;
                        case "3":
                            checkBoxAnswer3.Checked = true; break;
                        case "4":
                            checkBoxAnswer4.Checked = true; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("QuestionForm:InitQuestion", ex.Message.ToString());
                this.Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (QuestionId > 0)
                    {
                        Cursor = Cursors.WaitCursor;
                        SetStatusMessage("Deleting Question Data....", Color.LightGreen);
                        APIStatus res = Task.Run(() => ExamQuestionAPIClass.delExamQuestion(QuestionId,0)).Result;
                        textBoxQuestion.Text = string.Empty;
                        textBoxMarks.Text = string.Empty;
                        textBoxAnswer1.Text = string.Empty;
                        textBoxAnswer2.Text = string.Empty;
                        textBoxAnswer3.Text = string.Empty;
                        textBoxAnswer4.Text = string.Empty;

                        returnQuestionValues.recstatus = "D";
                        SetStatusMessage("Question Data Deleted Successfully....", Color.LimeGreen);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("QuestionForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating Question Data....", Color.LightGreen);
                    ExamQuestionClass examquestion = new ExamQuestionClass();
                    examquestion.id = QuestionId;
                    examquestion.examid = ExamId;
                    examquestion.question = textBoxQuestion.Text;
                    examquestion.answer_type = radioButtonSingleChoice.Checked ? "S" : "M";
                    examquestion.answer1 = textBoxAnswer1.Text;
                    examquestion.answer2 = textBoxAnswer2.Text;
                    examquestion.answer3 = textBoxAnswer3.Text;
                    examquestion.answer4 = textBoxAnswer4.Text;
                    string correct_answer = checkBoxAnswer1.Checked ? "1," : "";
                    if (checkBoxAnswer2.Checked) { correct_answer = correct_answer + "2,"; }
                    if (checkBoxAnswer3.Checked) { correct_answer = correct_answer + "3,"; }
                    if (checkBoxAnswer4.Checked) { correct_answer = correct_answer + "4,"; }
                    correct_answer = correct_answer.Remove(correct_answer.Length - 1, 1);
                    examquestion.correct_answer = correct_answer;
                    examquestion.marks = Int32.Parse(textBoxMarks.Text);
                    if (QuestionId > 0)
                    {
                        APIStatus res = Task.Run(() => ExamQuestionAPIClass.putExamQuestion(examquestion)).Result;
                        returnQuestionValues.question = examquestion.question;
                        returnQuestionValues.recstatus = "U";
                    }
                    else
                    {
                        APIStatus res = Task.Run(() => ExamQuestionAPIClass.postExamQuestion(examquestion)).Result;
                        QuestionId = Int32.Parse(UtilClass.RegxMatch(@"\d+", res.Message));
                        returnQuestionValues.id = QuestionId;
                        returnQuestionValues.qno = QNo;
                        returnQuestionValues.question = examquestion.question;
                        returnQuestionValues.recstatus = "I";
                    }
                    SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("QuestionForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool ValidateData()
        {
            try
            {
                if (textBoxQuestion.Text.Trim().Length == 0)
                {
                    SetStatusMessage("Question Data Missing....", Color.LemonChiffon);
                    return false;
                }
                if (textBoxAnswer1.Text.Trim().Length == 0)
                {
                    SetStatusMessage("Answer1 Data Missing....", Color.LemonChiffon);
                    return false;
                }
                if (textBoxAnswer2.Text.Trim().Length == 0)
                {
                    SetStatusMessage("Answer2 Data Missing....", Color.LemonChiffon);
                    return false;
                }
                if (textBoxAnswer3.Text.Trim().Length == 0)
                {
                    SetStatusMessage("Answer3 Data Missing....", Color.LemonChiffon);
                    return false;
                }
                if (textBoxAnswer4.Text.Trim().Length == 0)
                {
                    SetStatusMessage("Answer4 Data Missing....", Color.LemonChiffon);
                    return false;
                }
                if (!checkBoxAnswer1.Checked && !checkBoxAnswer2.Checked && !checkBoxAnswer3.Checked && !checkBoxAnswer4.Checked)
                {
                    SetStatusMessage("Correct Answer Data Missing....", Color.LemonChiffon);
                    return false;
                }
                int noofchecks = 0;
                if (checkBoxAnswer1.Checked) { noofchecks++; }
                if (checkBoxAnswer2.Checked) { noofchecks++; }
                if (checkBoxAnswer3.Checked) { noofchecks++; }
                if (checkBoxAnswer4.Checked) { noofchecks++; }
                if (radioButtonMultiChoice.Checked)
                {
                    if (noofchecks <= 1)
                    {
                        SetStatusMessage("Correct Answer Data Missing....", Color.LemonChiffon);
                        return false;
                    }
                }
                else
                {
                    if (noofchecks < 1)
                    {
                        SetStatusMessage("Correct Answer Data Missing....", Color.LemonChiffon);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("QuestionForm:ValidateData", ex.Message.ToString());
                this.Close();
                return false;
            }
        }
        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }

        private void textBoxMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
