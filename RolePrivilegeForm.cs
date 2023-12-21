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
    public partial class RolePrivilegeForm : Form
    {
        List<PrivilegeClass> Privileges = new List<PrivilegeClass>();
        public RolePrivilegeForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitRoleList()).Wait();
                hlabelId.Text = "";
                buttonClear_Click(null, null);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:RolePrivilegeForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitRoleList()
        {
            try
            {
                List<RoleClass> list = new List<RoleClass>();
                list = await RoleAPIClass.getRoles();
                listViewRoles.Items.Clear();
                foreach (RoleClass role in list)
                {
                    ListViewItem listItem = listViewRoles.Items.Add(role.role);
                    listItem.Tag = role.id;
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
                Privileges = await PrivilegeAPIClass.getPrivileges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:InitRoleList", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task<List<RolePrivilegeClass>> InitPrivilegeList(int id)
        {
            try
            {
                List<RolePrivilegeClass> list = new List<RolePrivilegeClass>();
                list = await RolePrivilegeAPIClass.getRolePrivilege(id);
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:InitPrivilegeList", ex.Message.ToString());
                this.Close();
                return new List<RolePrivilegeClass>();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewRoles_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                hlabelId.Text = listViewRoles.SelectedItems[0].Tag.ToString();
                List<RolePrivilegeClass> rolePrivileges = Task.Run(() => InitPrivilegeList(Int32.Parse(hlabelId.Text))).Result;
                listViewPrivileges.Items.Clear();
                if (rolePrivileges != null)
                {
                    foreach (RolePrivilegeClass roleprivilege in rolePrivileges)
                    {
                        PrivilegeClass privilege = Privileges.Find(x => x.id == roleprivilege.privilegeid);
                        ListViewItem listItem = listViewPrivileges.Items.Add(privilege.privileges);
                        listItem.Tag = roleprivilege.privilegeid;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    }
                }

                listViewAvlPrivileges.Items.Clear();
                foreach (PrivilegeClass privilege in Privileges)
                {
                    RolePrivilegeClass roleprivilege = null;
                    if (rolePrivileges != null)
                    {
                        roleprivilege = rolePrivileges.Find(x => x.privilegeid == privilege.id);
                    }
                    if (roleprivilege == null)
                    {
                        ListViewItem listItem = listViewAvlPrivileges.Items.Add(privilege.privileges);
                        listItem.Tag = privilege.id;
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    }
                }

                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:listViewRoles_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hlabelId.Text = "";
            listViewPrivileges.Items.Clear();
            listViewAvlPrivileges.Items.Clear();
            SetStatusMessage("", SystemColors.Control);
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            if (listViewAvlPrivileges.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewPrivileges.Items.Add(listViewAvlPrivileges.SelectedItems[0].Text);
                listItem.Tag = listViewAvlPrivileges.SelectedItems[0].Tag;
                listViewAvlPrivileges.SelectedItems[0].Remove();
            }
        }

        private void buttonRevoke_Click(object sender, EventArgs e)
        {
            if (listViewPrivileges.SelectedItems.Count > 0)
            {
                ListViewItem listItem = listViewAvlPrivileges.Items.Add(listViewPrivileges.SelectedItems[0].Text);
                listItem.Tag = listViewPrivileges.SelectedItems[0].Tag;
                listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                listViewPrivileges.SelectedItems[0].Remove();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPrivileges.Items.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating Role Privileges Data....", Color.LightGreen);
                    APIStatus res = Task.Run(() => RolePrivilegeAPIClass.delRolePrivilege(Int32.Parse(hlabelId.Text))).Result;
                    List<RolePrivilegeClass> rolePrivileges = new List<RolePrivilegeClass>();
                    foreach (ListViewItem item in listViewPrivileges.Items)
                    {
                        RolePrivilegeClass rolePrivilege = new RolePrivilegeClass();
                        rolePrivilege.roleid = Int32.Parse(hlabelId.Text);
                        rolePrivilege.privilegeid = Int32.Parse(item.Tag.ToString());
                        rolePrivileges.Add(rolePrivilege);
                        res = Task.Run(() => RolePrivilegeAPIClass.postRolePrivilege(rolePrivileges)).Result;
                        rolePrivileges.Remove(rolePrivilege);
                    }
                    SetStatusMessage("", SystemColors.Control);
                    Cursor = Cursors.Default;
                }
                else
                {
                    SetStatusMessage("No Role has been assigned....", Color.LemonChiffon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (listViewPrivileges.Items.Count > 0)
                    {
                        Cursor = Cursors.WaitCursor;
                        SetStatusMessage("Deleting Role Privileges Data....", Color.LightGreen);
                        APIStatus res = Task.Run(() => RolePrivilegeAPIClass.delRolePrivilege(Int32.Parse(hlabelId.Text))).Result;
                        buttonClear_Click(sender, e);
                        SetStatusMessage("", SystemColors.Control);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RolePrivilegeForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }
    }
}
