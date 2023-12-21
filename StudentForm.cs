using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ExamMaster
{
    public partial class StudentForm : Form
    {
        List<ExamClass> exams = new List<ExamClass>();
        public StudentForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitStudentList()).Wait();
                Task.Run(() => InitUserList()).Wait();
                Task.Run(() => InitExamList()).Wait();
                hlabelId.Text = "";
                listViewExamHistory.Items.Clear();
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:StudentForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitStudentList()
        {
            try
            {
                List<StudentClass> list = new List<StudentClass>();
                list = await StudentAPIClass.getStudents();
                listViewStudents.Items.Clear();
                foreach (StudentClass student in list)
                {
                    ListViewItem listItem = listViewStudents.Items.Add(student.studentname);
                    listItem.Tag = student.id;
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:InitStudentList", ex.Message.ToString());
                this.Close();
            }
        }
        private async Task InitUserList()
        {
            try
            {
                List<UserClass> list = new List<UserClass>();
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
                list = await UserAPIClass.getUsers();
                comboBoxUserAccount.Items.Clear();
                foreach (UserClass user in list)
                {
                    keyValuePairs.Add(user.id, user.useraccount);
                }
                comboBoxUserAccount.DataSource = new BindingSource(keyValuePairs, null);
                comboBoxUserAccount.DisplayMember = "Value";
                comboBoxUserAccount.ValueMember = "Key";
                comboBoxUserAccount.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:InitUserList", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitExamList()
        {
            exams = Task.Run(() => ExamAPIClass.getExams()).Result;
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

        private void listViewStudents_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                buttonClear_Click(sender, e);
                SetStatusMessage("Fetching Student Data....", Color.LightGreen);
                StudentClass student = new StudentClass();
                string id = listViewStudents.SelectedItems[0].Tag.ToString();
                hlabelId.Text = id;
                student = Task.Run(() => StudentAPIClass.getStudent(Int32.Parse(id),0)).Result;

                List<StudentExamClass> studentExams = new List<StudentExamClass>();
                studentExams = Task.Run(() => StudentExamAPIClass.getStudentExam(0, Int32.Parse(id),0)).Result;

                if (studentExams is not null)
                {
                    foreach (StudentExamClass studentexam in studentExams)
                    {
                        ExamClass exam = exams.Find(x => x.id == studentexam.examid);
                        ListViewItem listItem = listViewExamHistory.Items.Add(exam.examname);
                        listItem.Tag = studentexam.id;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem1 = listItem.SubItems.Add(studentexam.examscore.ToString());
                        ListViewItem.ListViewSubItem subItem2 = listItem.SubItems.Add(studentexam.attemptno.ToString());
                        ListViewItem.ListViewSubItem subItem3 = listItem.SubItems.Add(studentexam.starttime.Substring(0, studentexam.starttime.IndexOf("T")));
                        subItem1.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        subItem2.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        subItem3.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                    }
                }

                textBoxStudentName.Text = student.studentname;
                comboBoxUserAccount.SelectedValue = student.userid;
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:listViewStudents_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxStudentName.Text = "";
            comboBoxUserAccount.SelectedIndex = -1;
            listViewExamHistory.Items.Clear();
            hlabelId.Text = "";
            SetStatusMessage("", SystemColors.Control);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating Student Data....", Color.LightGreen);
                    StudentClass student = new StudentClass();
                    student.id = hlabelId.Text.Trim() == "" ? 0 : Int32.Parse(hlabelId.Text);
                    student.studentname = textBoxStudentName.Text;
                    student.userid = Int32.Parse(comboBoxUserAccount.SelectedValue.ToString());
                    if (student.id != 0)
                    {
                        APIStatus res = Task.Run(() => StudentAPIClass.putStudent(student)).Result;
                        listViewStudents.SelectedItems[0].Text = textBoxStudentName.Text;
                    }
                    else
                    {
                        APIStatus res = Task.Run(() => StudentAPIClass.postStudent(student)).Result;
                        hlabelId.Text = UtilClass.RegxMatch(@"\d+", res.Message);
                        ListViewItem listItem = listViewStudents.Items.Add(student.studentname);
                        listItem.Tag = UtilClass.RegxMatch(@"\d+", res.Message);
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        listViewStudents.SelectedItems.Clear();
                        listViewStudents.Items[listViewStudents.Items.Count - 1].Selected = true;
                    }
                    SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool ValidateData()
        {
            if (textBoxStudentName.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("Student Name Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (comboBoxUserAccount.SelectedIndex < 0) 
            {
                SetStatusMessage("User Account Data Missing....", Color.LemonChiffon);
                return false;
            }
            return true;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (hlabelId.Text != string.Empty)
                    {
                        Cursor = Cursors.WaitCursor;
                        SetStatusMessage("Deleting Student Data....", Color.LightGreen);
                        APIStatus res1 = Task.Run(() => StudentExamAPIClass.delStudentExam(0, Int32.Parse(hlabelId.Text),0)).Result;
                        if (res1 is not null)
                        {
                            APIStatus res2 = Task.Run(() => StudentAPIClass.delStudent(Int32.Parse(hlabelId.Text), 0)).Result;
                            listViewStudents.SelectedItems[0].Remove();
                            buttonClear_Click(sender, e);
                            SetStatusMessage("Student Data Deleted Successfully....", Color.LimeGreen);
                        }
                        else
                        {
                            SetStatusMessage("", SystemColors.Control);
                        }
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("StudentForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }
    }
}
