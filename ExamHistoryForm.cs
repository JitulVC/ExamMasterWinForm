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
    public partial class ExamHistoryForm : Form
    {
        private List<ExamQuestionClass> examQuestions = new List<ExamQuestionClass>();
        private List<StudentAnswerClass> studentAnswers = new List<StudentAnswerClass>();
        private int ExamID = 0;
        private int StudentExamID = 0;
        private int NoOfQuestions = 0;
        private int Idx = 1;
        public ExamHistoryForm(int examid, int studentexamid, int noofquestions)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                ExamID = examid;
                StudentExamID = studentexamid;
                NoOfQuestions = noofquestions;
                Task.Run(() => InitExamQuestionList()).Wait();
                Task.Run(() => InitStudentAnswerList(studentexamid)).Wait();
                if (studentAnswers.Count == 0)
                {
                    this.Close();
                }
                DisplayData(Idx);
                textBoxQuestion.Focus();
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("ExamHistoryForm:ExamHistoryForm", ex.Message.ToString());
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
                UtilClass.WriteLogs("ExamHistoryForm:InitExamQuestionList", ex.Message.ToString());
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
                UtilClass.WriteLogs("ExamHistoryForm:InitStudentAnswerList", ex.Message.ToString());
                this.Close();
            }
        }

        private void DisplayData(int idx)
        {
            SetStatusMessage("", SystemColors.Control);
            if (studentAnswers[idx - 1].response_result.Equals("C"))
            {
                groupBoxQuestion.Text = "Question: " + idx + "/" + NoOfQuestions + " (Correct)";
                groupBoxQuestion.ForeColor = Color.Green;
            }
            else if (studentAnswers[idx - 1].response_result.Equals("W"))
            {
                groupBoxQuestion.Text = "Question: " + idx + "/" + NoOfQuestions + " (Wrong)";
                groupBoxQuestion.ForeColor = Color.Red;
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
            checkBoxAnswer1.Checked = false;
            checkBoxAnswer2.Checked = false;
            checkBoxAnswer3.Checked = false;
            checkBoxAnswer4.Checked = false;
            radioButtonAnswer1.Checked = false;
            radioButtonAnswer2.Checked = false;
            radioButtonAnswer3.Checked = false;
            radioButtonAnswer4.Checked = false;
            pictureBoxAns1Correct.Visible = false;
            pictureBoxAns2Correct.Visible = false;
            pictureBoxAns3Correct.Visible = false;
            pictureBoxAns4Correct.Visible = false;
            pictureBoxAns1Wrong.Visible = false;
            pictureBoxAns2Wrong.Visible = false;
            pictureBoxAns3Wrong.Visible = false;
            pictureBoxAns4Wrong.Visible = false;

            string[] correct_answers = examQuestions[idx - 1].correct_answer.Split(",");
            string[] student_answers = studentAnswers[idx - 1].question_response.Split(",");
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
                SetRadioCheckBox("R", correct_answers, student_answers);
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
                SetRadioCheckBox("C", correct_answers, student_answers);
            }

        }

        private void SetRadioCheckBox(string radio_or_checkbox, string[] correct_answers, string[] student_answers)
        {
            foreach (string correct_answer in correct_answers)
            {
                switch (correct_answer)
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

            foreach (string student_answer in student_answers) 
            {
                switch (student_answer)
                {
                    case "1":
                        if (checkBoxAnswer1.Checked || radioButtonAnswer1.Checked)
                        {
                            pictureBoxAns1Correct.Visible = true;
                        }
                        else
                        {
                            pictureBoxAns1Wrong.Visible = true;
                        }
                        break;
                    case "2":
                        if (checkBoxAnswer2.Checked || radioButtonAnswer2.Checked)
                        {
                            pictureBoxAns2Correct.Visible = true;
                        }
                        else
                        {
                            pictureBoxAns2Wrong.Visible = true;
                        }
                        break;
                    case "3":
                        if (checkBoxAnswer3.Checked || radioButtonAnswer3.Checked)
                        {
                            pictureBoxAns3Correct.Visible = true;
                        }
                        else
                        {
                            pictureBoxAns3Wrong.Visible = true;
                        }
                        break;
                    case "4":
                        if (checkBoxAnswer4.Checked || radioButtonAnswer4.Checked)
                        {
                            pictureBoxAns4Correct.Visible = true;
                        }
                        else
                        {
                            pictureBoxAns4Wrong.Visible = true;
                        }
                        break;
                }
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Idx < examQuestions.Count)
            {
                Idx++;
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
                Idx--;
                DisplayData(Idx);
            }
            else
            {
                SetStatusMessage("First Question...", Color.LightGreen);
            }
        }
    }
}
