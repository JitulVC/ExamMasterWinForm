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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            try
            {
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitRoleList()).Wait();
                hlabelId.Text = "";
                SetStatusMessage("", SystemColors.Control);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RoleForm:RoleForm", ex.Message.ToString());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RoleForm:InitRoleList", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewRoles_Click(object sender, EventArgs e)
        {
            hlabelId.Text = listViewRoles.SelectedItems[0].Tag.ToString();
            textBoxRole.Text = listViewRoles.SelectedItems[0].Text;
            SetStatusMessage("", SystemColors.Control);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hlabelId.Text = "";
            textBoxRole.Text = "";
            SetStatusMessage("", SystemColors.Control);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SetStatusMessage("Updating Role Data....", Color.LightGreen);
                List<RoleClass> role = new List<RoleClass>();
                role.Add(new RoleClass());
                role[0].id = hlabelId.Text.Trim() == "" ? 0 : Int32.Parse(hlabelId.Text);
                role[0].role = textBoxRole.Text;
                if (CheckDuplicateRole())
                {
                    APIStatus res = Task.Run(() => RoleAPIClass.putRole(role)).Result;
                    listViewRoles.SelectedItems[0].SubItems[1].Text = textBoxRole.Text;
                }
                else
                {
                    APIStatus res = Task.Run(() => RoleAPIClass.postRole(role)).Result;
                    hlabelId.Text = UtilClass.RegxMatch(@"\d+", res.message);
                    ListViewItem listItem = listViewRoles.Items.Add(role[0].role);
                    listItem.Tag = UtilClass.RegxMatch(@"\d+", res.message);
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    listViewRoles.SelectedItems.Clear();
                    listViewRoles.Items[listViewRoles.Items.Count - 1].Selected = true;
                }
                SetStatusMessage("Updated Successfully....", Color.LimeGreen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RoleForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool CheckDuplicateRole()
        {
            foreach (ListViewItem eachItem in listViewRoles.Items)
            {
                if (eachItem.Text.Equals(textBoxRole.Text.Trim()))
                {
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
                        SetStatusMessage("Deleting Role Data....", Color.LightGreen);
                        APIStatus res = Task.Run(() => RoleAPIClass.delRole(Int32.Parse(hlabelId.Text))).Result;
                        listViewRoles.SelectedItems[0].Remove();
                        buttonClear_Click(sender, e);
                        SetStatusMessage("Role Data Deleted Successfully....", Color.LimeGreen);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("RoleForm:buttonDelete_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private void SetStatusMessage(string StatusMessage, Color color)
        {
            statusStripMsg.BackColor = color;
            toolStripStatusLabelMsg.Text = StatusMessage;
        }
    }
}
