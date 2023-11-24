namespace ExamMaster
{
    partial class RolePrivilegeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Administrator" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Superuser" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "ManageUser:Admin" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "ManageUser:Readonly" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "ManageRole:Admin" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "ManageRole:Readonly" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolePrivilegeForm));
            groupBoxRoles = new GroupBox();
            listViewRoles = new ListView();
            columnHeaderRole = new ColumnHeader();
            groupBoxPrivileges = new GroupBox();
            listViewPrivileges = new ListView();
            columnHeaderPrivilege = new ColumnHeader();
            groupBoxAvailablePrivileges = new GroupBox();
            listViewAvlPrivileges = new ListView();
            columnHeader1 = new ColumnHeader();
            buttonClose = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            toolTipButton = new ToolTip(components);
            buttonRevoke = new Button();
            buttonAssign = new Button();
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            hlabelId = new Label();
            groupBoxRoles.SuspendLayout();
            groupBoxPrivileges.SuspendLayout();
            groupBoxAvailablePrivileges.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRoles
            // 
            groupBoxRoles.Controls.Add(listViewRoles);
            groupBoxRoles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxRoles.Location = new Point(23, 68);
            groupBoxRoles.Name = "groupBoxRoles";
            groupBoxRoles.Size = new Size(318, 391);
            groupBoxRoles.TabIndex = 1;
            groupBoxRoles.TabStop = false;
            groupBoxRoles.Text = "Roles";
            // 
            // listViewRoles
            // 
            listViewRoles.Columns.AddRange(new ColumnHeader[] { columnHeaderRole });
            listViewRoles.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewRoles.FullRowSelect = true;
            listViewRoles.GridLines = true;
            listViewRoles.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewRoles.Location = new Point(11, 38);
            listViewRoles.Name = "listViewRoles";
            listViewRoles.Size = new Size(297, 343);
            listViewRoles.TabIndex = 0;
            listViewRoles.UseCompatibleStateImageBehavior = false;
            listViewRoles.View = View.Details;
            listViewRoles.Click += listViewRoles_Click;
            // 
            // columnHeaderRole
            // 
            columnHeaderRole.Text = "Role";
            columnHeaderRole.Width = 265;
            // 
            // groupBoxPrivileges
            // 
            groupBoxPrivileges.Controls.Add(listViewPrivileges);
            groupBoxPrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPrivileges.Location = new Point(379, 68);
            groupBoxPrivileges.Name = "groupBoxPrivileges";
            groupBoxPrivileges.Size = new Size(318, 391);
            groupBoxPrivileges.TabIndex = 14;
            groupBoxPrivileges.TabStop = false;
            groupBoxPrivileges.Text = "Assigned Privileges";
            // 
            // listViewPrivileges
            // 
            listViewPrivileges.Columns.AddRange(new ColumnHeader[] { columnHeaderPrivilege });
            listViewPrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewPrivileges.FullRowSelect = true;
            listViewPrivileges.GridLines = true;
            listViewPrivileges.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listViewPrivileges.Location = new Point(11, 38);
            listViewPrivileges.Name = "listViewPrivileges";
            listViewPrivileges.Size = new Size(297, 343);
            listViewPrivileges.TabIndex = 0;
            listViewPrivileges.UseCompatibleStateImageBehavior = false;
            listViewPrivileges.View = View.Details;
            // 
            // columnHeaderPrivilege
            // 
            columnHeaderPrivilege.Text = "Privilege";
            columnHeaderPrivilege.Width = 265;
            // 
            // groupBoxAvailablePrivileges
            // 
            groupBoxAvailablePrivileges.Controls.Add(listViewAvlPrivileges);
            groupBoxAvailablePrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxAvailablePrivileges.Location = new Point(797, 68);
            groupBoxAvailablePrivileges.Name = "groupBoxAvailablePrivileges";
            groupBoxAvailablePrivileges.Size = new Size(318, 391);
            groupBoxAvailablePrivileges.TabIndex = 15;
            groupBoxAvailablePrivileges.TabStop = false;
            groupBoxAvailablePrivileges.Text = "Available Privileges";
            // 
            // listViewAvlPrivileges
            // 
            listViewAvlPrivileges.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewAvlPrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewAvlPrivileges.FullRowSelect = true;
            listViewAvlPrivileges.GridLines = true;
            listViewAvlPrivileges.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6 });
            listViewAvlPrivileges.Location = new Point(11, 38);
            listViewAvlPrivileges.Name = "listViewAvlPrivileges";
            listViewAvlPrivileges.Size = new Size(297, 343);
            listViewAvlPrivileges.TabIndex = 0;
            listViewAvlPrivileges.UseCompatibleStateImageBehavior = false;
            listViewAvlPrivileges.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Privilege";
            columnHeader1.Width = 265;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1071, -1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 16;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(1026, 480);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(55, 58);
            buttonDelete.TabIndex = 19;
            toolTipButton.SetToolTip(buttonDelete, "Delete");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(924, 480);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 58);
            buttonClear.TabIndex = 18;
            toolTipButton.SetToolTip(buttonClear, "Clear");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(850, 480);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 17;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRevoke
            // 
            buttonRevoke.Image = (Image)resources.GetObject("buttonRevoke.Image");
            buttonRevoke.Location = new Point(723, 183);
            buttonRevoke.Name = "buttonRevoke";
            buttonRevoke.Size = new Size(55, 58);
            buttonRevoke.TabIndex = 21;
            toolTipButton.SetToolTip(buttonRevoke, "Revoke Privilege");
            buttonRevoke.UseVisualStyleBackColor = true;
            buttonRevoke.Click += buttonRevoke_Click;
            // 
            // buttonAssign
            // 
            buttonAssign.Image = (Image)resources.GetObject("buttonAssign.Image");
            buttonAssign.Location = new Point(723, 268);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(55, 58);
            buttonAssign.TabIndex = 22;
            toolTipButton.SetToolTip(buttonAssign, "Assign Privilege");
            buttonAssign.UseVisualStyleBackColor = true;
            buttonAssign.Click += buttonAssign_Click;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 548);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1127, 35);
            statusStripMsg.TabIndex = 23;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(676, 501);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(75, 25);
            hlabelId.TabIndex = 24;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // RolePrivilegeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 583);
            ControlBox = false;
            Controls.Add(hlabelId);
            Controls.Add(statusStripMsg);
            Controls.Add(buttonAssign);
            Controls.Add(buttonRevoke);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonSave);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxAvailablePrivileges);
            Controls.Add(groupBoxPrivileges);
            Controls.Add(groupBoxRoles);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RolePrivilegeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Role Privilege Management";
            groupBoxRoles.ResumeLayout(false);
            groupBoxPrivileges.ResumeLayout(false);
            groupBoxAvailablePrivileges.ResumeLayout(false);
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxRoles;
        private ListView listViewRoles;
        private ColumnHeader columnHeaderRole;
        private GroupBox groupBoxPrivileges;
        private ListView listViewPrivileges;
        private ColumnHeader columnHeaderPrivilege;
        private GroupBox groupBoxAvailablePrivileges;
        private ListView listViewAvlPrivileges;
        private ColumnHeader columnHeader1;
        private Button buttonClose;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private ToolTip toolTipButton;
        private Button buttonRevoke;
        private Button buttonAssign;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
    }
}