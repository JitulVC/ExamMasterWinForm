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
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExamMaster
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitUserList()).Wait();
                Task.Run(() => InitRoleList()).Wait();
                hlabelId.Text = "";
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:UserForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitUserList()
        {
            try
            {
                List<UserClass> list = new List<UserClass>();
                list = await UserAPIClass.getUsers();
                listViewUsers.Items.Clear();
                foreach (UserClass user in list)
                {
                    ListViewItem listItem = listViewUsers.Items.Add(user.useraccount);
                    listItem.Tag = user.id;
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(user.username);
                    subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:InitUserList", ex.Message.ToString());
                this.Close();
            }
        }
        private async Task InitRoleList()
        {
            try
            {
                List<RoleClass> list = new List<RoleClass>();
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
                list = await RoleAPIClass.getRoles();
                comboBoxRole.Items.Clear();
                foreach (RoleClass role in list)
                {
                    keyValuePairs.Add(role.id, role.role);
                }
                comboBoxRole.DataSource = new BindingSource(keyValuePairs, null);
                comboBoxRole.DisplayMember = "Value";
                comboBoxRole.ValueMember = "Key";
                comboBoxRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:InitRoleList", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<UserClass> GetUserData(int id)
        {
            try
            {
                UserClass list = new UserClass();
                list = await UserAPIClass.getUser(id);
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:GetUserData", ex.Message.ToString());
                this.Close();
                return new UserClass();
            }
        }

        private void listViewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Fetching User Data....", Color.LightGreen);
                UserClass list = new UserClass();
                string id = listViewUsers.SelectedItems[0].Tag.ToString();
                list = Task.Run(() => GetUserData(Int32.Parse(id))).Result;
                hlabelId.Text = list.id.ToString();
                textBoxUserAccount.Text = list.useraccount;
                textBoxUserAccount.ReadOnly = true;
                textBoxUserName.Text = list.username;
                comboBoxRole.SelectedValue = list.roleid;
                textBoxAPIKey.Text = list.apikey;
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:listViewUsers_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hlabelId.Text = "";
            textBoxUserAccount.Text = "";
            textBoxUserAccount.ReadOnly = false;
            textBoxUserName.Text = "";
            comboBoxRole.SelectedIndex = -1;
            textBoxAPIKey.Text = "";
            SetStatusMessage("", SystemColors.Control);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating User Data....", Color.LightGreen);
                    List<UserClass> user = new List<UserClass>();
                    user.Add(new UserClass());

                    user[0].id = hlabelId.Text.Trim() == "" ? 0 : Int32.Parse(hlabelId.Text);
                    user[0].useraccount = textBoxUserAccount.Text;
                    user[0].username = textBoxUserName.Text;
                    user[0].passcode = "123456";
                    user[0].roleid = Int32.Parse(comboBoxRole.SelectedValue.ToString());
                    user[0].apikey = textBoxAPIKey.Text;
                    if (user[0].id > 0)
                    {
                        APIStatus res = Task.Run(() => UserAPIClass.putUser(user)).Result;
                        listViewUsers.SelectedItems[0].SubItems[1].Text = textBoxUserName.Text;
                    }
                    else
                    {
                        APIStatus res = Task.Run(() => UserAPIClass.postUser(user)).Result;
                        hlabelId.Text = UtilClass.RegxMatch(@"\d+", res.Message);
                        ListViewItem listItem = listViewUsers.Items.Add(user[0].useraccount);
                        listItem.Tag = UtilClass.RegxMatch(@"\d+", res.Message);
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        ListViewItem.ListViewSubItem subItem = listItem.SubItems.Add(user[0].username);
                        subItem.Font = new Font("Segeo UI", 10, FontStyle.Regular);
                        listViewUsers.SelectedItems.Clear();
                        listViewUsers.Items[listViewUsers.Items.Count - 1].Selected = true;
                    }
                    SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool ValidateData()
        {
            if (textBoxUserAccount.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("User Account Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (textBoxUserName.Text.Trim().Length <= 0)
            {
                SetStatusMessage("User Name Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (comboBoxRole.SelectedIndex < 0)
            {
                SetStatusMessage("Role Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (hlabelId.Text == "" && CheckDuplicateUserAccount())
            {
                return false;
            }
            return true;
        }
        private bool CheckDuplicateUserAccount()
        {
            foreach (ListViewItem eachItem in listViewUsers.Items)
            {
                if (eachItem.Text.Equals(textBoxUserAccount.Text.Trim()))
                {
                    SetStatusMessage("Duplicate User Account....", Color.LemonChiffon);
                    return true;
                }
            }
            return false;
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
                        SetStatusMessage("Deleting User Data....", Color.LightGreen);
                        APIStatus res = Task.Run(() => UserAPIClass.delUser(Int32.Parse(hlabelId.Text))).Result;
                        listViewUsers.SelectedItems[0].Remove();
                        buttonClear_Click(sender, e);
                        SetStatusMessage("User Data Deleted Successfully....", Color.LimeGreen);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("UserForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor= color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }
    }
}
