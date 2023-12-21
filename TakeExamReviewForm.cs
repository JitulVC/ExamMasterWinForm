using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class TakeExamReviewForm : Form
    {
        private List<StudentAnswerClass> studentAnswers = new List<StudentAnswerClass>();
        private List<ExamQuestionClass> examQuestions = new List<ExamQuestionClass>();
        public TakeExamReviewForm(List<StudentAnswerClass> studentanswers, List<ExamQuestionClass> examquestions)
        {
            try
            {
                InitializeComponent();
                studentAnswers = studentanswers;
                examQuestions = examquestions;
                listViewQuestions.Items.Clear();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("TakeExamReviewForm:TakeExamReviewForm", ex.Message.ToString());
                this.Close();
            }
        }

        private void DisplayData()
        {
            int id = 0;
            string question_response = string.Empty;
            foreach (ExamQuestionClass examQuestion in examQuestions)
            {
                id++;
                ListViewItem listItem = listViewQuestions.Items.Add(id.ToString());
                listItem.Tag = examQuestion.id;
                listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                ListViewItem.ListViewSubItem subItem1 = listItem.SubItems.Add(examQuestion.question);
                subItem1.Font = new Font("Segeo UI", 10, FontStyle.Regular);

                if (studentAnswers[id - 1].response_result.Equals("A"))
                {
                    question_response = "Answered";
                }
                else if (studentAnswers[id - 1].response_result.Equals("S"))
                {
                    question_response = "Skipped";
                }
                else if (studentAnswers[id - 1].response_result.Equals("R"))
                {
                    question_response = "Review";
                }
                ListViewItem.ListViewSubItem subItem2 = listItem.SubItems.Add(question_response);
                subItem2.Font = new Font("Segeo UI", 10, FontStyle.Regular);
            }
        }
        private void listViewQuestions_DoubleClick(object sender, EventArgs e)
        {
            TakeExamReviewFormReturnValue.questionid = Int32.Parse(listViewQuestions.SelectedItems[0].Index.ToString());
            TakeExamReviewFormReturnValue.reviewtype = "C";
            this.Close();
        }

        private void buttonReviewAll_Click(object sender, EventArgs e)
        {
            TakeExamReviewFormReturnValue.reviewtype = "A";
            this.Close();
        }

        private void buttonReviewSkipped_Click(object sender, EventArgs e)
        {
            TakeExamReviewFormReturnValue.reviewtype = "S";
            this.Close();
        }

        private void buttonReviewMarked_Click(object sender, EventArgs e)
        {
            TakeExamReviewFormReturnValue.reviewtype = "R";
            this.Close();
        }
    }
}
