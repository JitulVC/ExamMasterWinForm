using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class PrivilegeForm : Form
    {
        public PrivilegeForm()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                InitializeComponent();
                SetStatusMessage("Fetching Data....", Color.LightGreen);
                Task.Run(() => InitPrivilegeList()).Wait();
                hlabelId.Text = "";
                SetStatusMessage("", SystemColors.Control);
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("PrivilegeForm:PrivilegeForm", ex.Message.ToString());
                this.Close();
            }
        }

        private async Task InitPrivilegeList()
        {
            try
            {
                List<PrivilegeClass> list = new List<PrivilegeClass>();
                list = await PrivilegeAPIClass.getPrivileges();
                listViewPrivileges.Items.Clear();
                foreach (PrivilegeClass privilege in list)
                {
                    ListViewItem listItem = listViewPrivileges.Items.Add(privilege.privileges);
                    listItem.Tag = privilege.id;
                    listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("PrivilegeForm:InitPrivilegeList", ex.Message.ToString());
                this.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listViewPrivilege_Click(object sender, EventArgs e)
        {
            hlabelId.Text = listViewPrivileges.SelectedItems[0].Tag.ToString();
            textBoxPrivilege.Text = listViewPrivileges.SelectedItems[0].Text;
            SetStatusMessage("", SystemColors.Control);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            hlabelId.Text = "";
            textBoxPrivilege.Text = "";
            SetStatusMessage("", SystemColors.Control);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Cursor = Cursors.WaitCursor;
                    SetStatusMessage("Updating Privilege Data....", Color.LightGreen);
                    List<PrivilegeClass> privilege = new List<PrivilegeClass>();
                    privilege.Add(new PrivilegeClass());
                    privilege[0].id = hlabelId.Text.Trim() == "" ? 0 : Int32.Parse(hlabelId.Text);
                    privilege[0].privileges = textBoxPrivilege.Text;
                    if (privilege[0].id > 0)
                    {
                        APIStatus res = Task.Run(() => PrivilegeAPIClass.putPrivilege(privilege)).Result;
                        listViewPrivileges.SelectedItems[0].SubItems[0].Text = textBoxPrivilege.Text;
                    }
                    else
                    {
                        APIStatus res = Task.Run(() => PrivilegeAPIClass.postPrivilege(privilege)).Result;
                        hlabelId.Text = UtilClass.RegxMatch(@"\d+", res.Message);
                        ListViewItem listItem = listViewPrivileges.Items.Add(privilege[0].privileges);
                        listItem.Tag = UtilClass.RegxMatch(@"\d+", res.Message);
                        listItem.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        listViewPrivileges.SelectedItems.Clear();
                        listViewPrivileges.Items[listViewPrivileges.Items.Count - 1].Selected = true;
                    }
                    SetStatusMessage("Updated Successfully....", Color.LimeGreen);
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("PrivilegeForm:buttonSave_Click", ex.Message.ToString());
                this.Close();
            }
        }

        private bool ValidateData()
        {
            if (textBoxPrivilege.Text.Trim().Length <= 0) 
            {
                SetStatusMessage("Privilege Data Missing....", Color.LemonChiffon);
                return false;
            }
            if (hlabelId.Text == "" && CheckDuplicatePrivilege())
            {
                SetStatusMessage("Duplicate Privilege Data....", Color.LemonChiffon);
                return false;
            }
            return true;
        }
        private bool CheckDuplicatePrivilege()
        {
            foreach (ListViewItem eachItem in listViewPrivileges.Items)
            {
                if (eachItem.Text.Equals(textBoxPrivilege.Text.Trim()))
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
                        Cursor = Cursors.WaitCursor;
                        SetStatusMessage("Deleting Privilege Data....", Color.LightGreen);
                        APIStatus res = Task.Run(() => PrivilegeAPIClass.delPrivilege(Int32.Parse(hlabelId.Text))).Result;
                        listViewPrivileges.SelectedItems[0].Remove();
                        buttonClear_Click(sender, e);
                        SetStatusMessage("Privilege Data Deleted Successfully....", Color.LimeGreen);
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("PrivilegeForm:buttonDelete_Click", ex.Message.ToString());
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
