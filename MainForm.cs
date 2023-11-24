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
            toolStripMain.Enabled = false;
            toolStripStatusLabelMsg.Text = "Connecting to Server";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => GetAPISessionKey()).Wait();

                LoginForm loginForm = new LoginForm();
                loginForm.MdiParent = this;
                loginForm.FormClosed += new FormClosedEventHandler(childFormClosed);
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("LoginForm", ex.Message.ToString());
                this.Close();
            }
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
                    StudentExamForm studentexamForm = new StudentExamForm();
                    studentexamForm.MdiParent = this;
                    studentexamForm.Show();
                }
                else
                {
                    toolStripMain.Enabled = true;
                }
            }
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            roleForm.MdiParent = this;
            roleForm.Show();
        }

        private void toolStripButtonPrivilege_Click(object sender, EventArgs e)
        {
            PrivilegeForm privilegeForm = new PrivilegeForm();
            privilegeForm.MdiParent = this;
            privilegeForm.Show();
        }

        private void toolStripButtonRolePrivilege_Click(object sender, EventArgs e)
        {
            RolePrivilegeForm roleprivilegeForm = new RolePrivilegeForm();
            roleprivilegeForm.MdiParent = this;
            roleprivilegeForm.Show();
        }

        private void toolStripButtonExam_Click(object sender, EventArgs e)
        {
            SetExamForm setexamForm = new SetExamForm();
            setexamForm.MdiParent = this;
            setexamForm.Show();
        }

        private void toolStripButtonStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.MdiParent = this;
            studentForm.Show();
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