using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            toolStripMain.Visible = false;
            toolStripStatusLabelMsg.Text = "Connecting to Server";
        }

        private async Task GetAPISessionKey()
        {
            Dictionary<string, string> keyValuePairs = await UtilClass.GetSessionKey();

            GlobalValues.APIToken = keyValuePairs.ElementAt(0).Value;
            GlobalValues.APIRefreshToken = keyValuePairs.ElementAt(1).Value;
            toolStripStatusLabelMsg.Text = "Connected to Server";
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalValues.LoginStatus == true)
            {
                toolStripStatusLabelMsg.Text = "Logged in as " + GlobalValues.LoginUser.username;
                if (GlobalValues.LoginUser.roleid == 4)
                {
                    Cursor = Cursors.WaitCursor;
                    StudentExamForm studentexamForm = new StudentExamForm();
                    studentexamForm.MdiParent = this;
                    studentexamForm.Show();
                    Cursor = Cursors.Default;
                }
                else
                {
                    toolStripMain.Visible = true;
                }
            }
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UserForm userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RoleForm roleForm = new RoleForm();
            roleForm.MdiParent = this;
            roleForm.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripButtonPrivilege_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            PrivilegeForm privilegeForm = new PrivilegeForm();
            privilegeForm.MdiParent = this;
            privilegeForm.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripButtonRolePrivilege_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RolePrivilegeForm roleprivilegeForm = new RolePrivilegeForm();
            roleprivilegeForm.MdiParent = this;
            roleprivilegeForm.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripButtonExam_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetExamForm setexamForm = new SetExamForm();
            setexamForm.MdiParent = this;
            setexamForm.Show();
            Cursor = Cursors.Default;
        }

        private void toolStripButtonStudent_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            StudentForm studentForm = new StudentForm();
            studentForm.MdiParent = this;
            studentForm.Show();
            Cursor = Cursors.Default;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => GetAPISessionKey()).Wait();

                LoginForm loginForm = new LoginForm();
                loginForm.MdiParent = this;
                loginForm.FormClosed += new FormClosedEventHandler(childFormClosed);
                System.Threading.Thread.Sleep(1000);
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("MainForm:MainForm_Shown", ex.Message.ToString());
                this.Close();
            }
        }
    }

    public static class GlobalValues
    {
        public static string? APIUrl { get; set; }
        public static string? APIUserAccount { get; set; }
        public static string? APIPasscode { get; set; }
        public static string? APIKey { get; set; }
        public static string? APIToken { get; set; }
        public static string? APIRefreshToken { get; set; }

        public static bool? LoginStatus { get; set; } 
        public static UserClass? LoginUser { get; set; }
    }
}