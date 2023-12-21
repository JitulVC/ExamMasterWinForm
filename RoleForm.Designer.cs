namespace ExamMaster
{
    partial class RoleForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Administrator" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Superuser" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleForm));
            groupBoxRoles = new GroupBox();
            listViewRoles = new ListView();
            columnHeaderRole = new ColumnHeader();
            buttonClose = new Button();
            groupBoxRoleData = new GroupBox();
            hlabelId = new Label();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            textBoxRole = new TextBox();
            labelRole = new Label();
            toolTipButton = new ToolTip(components);
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxRoles.SuspendLayout();
            groupBoxRoleData.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRoles
            // 
            groupBoxRoles.Controls.Add(listViewRoles);
            groupBoxRoles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxRoles.Location = new Point(36, 57);
            groupBoxRoles.Name = "groupBoxRoles";
            groupBoxRoles.Size = new Size(318, 391);
            groupBoxRoles.TabIndex = 0;
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
            columnHeaderRole.Width = 260;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(892, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 12;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupBoxRoleData
            // 
            groupBoxRoleData.Controls.Add(hlabelId);
            groupBoxRoleData.Controls.Add(buttonDelete);
            groupBoxRoleData.Controls.Add(buttonClear);
            groupBoxRoleData.Controls.Add(buttonSave);
            groupBoxRoleData.Controls.Add(textBoxRole);
            groupBoxRoleData.Controls.Add(labelRole);
            groupBoxRoleData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxRoleData.Location = new Point(376, 57);
            groupBoxRoleData.Name = "groupBoxRoleData";
            groupBoxRoleData.Size = new Size(546, 222);
            groupBoxRoleData.TabIndex = 11;
            groupBoxRoleData.TabStop = false;
            groupBoxRoleData.Text = "Role Info";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(29, 179);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 11;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(449, 153);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(55, 58);
            buttonDelete.TabIndex = 10;
            toolTipButton.SetToolTip(buttonDelete, "Delete");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(347, 153);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 58);
            buttonClear.TabIndex = 9;
            toolTipButton.SetToolTip(buttonClear, "Clear");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(273, 153);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 8;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxRole
            // 
            textBoxRole.Location = new Point(27, 78);
            textBoxRole.MaxLength = 40;
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(477, 34);
            textBoxRole.TabIndex = 1;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRole.Location = new Point(27, 50);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(56, 28);
            labelRole.TabIndex = 0;
            labelRole.Text = "Role:";
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 482);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(946, 35);
            statusStripMsg.TabIndex = 13;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 517);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxRoleData);
            Controls.Add(groupBoxRoles);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RoleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Role Management";
            groupBoxRoles.ResumeLayout(false);
            groupBoxRoleData.ResumeLayout(false);
            groupBoxRoleData.PerformLayout();
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxRoles;
        private ListView listViewRoles;
        private ColumnHeader columnHeaderRole;
        private Button buttonClose;
        private GroupBox groupBoxRoleData;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private TextBox textBoxRole;
        private Label labelRole;
        private ToolTip toolTipButton;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
    }
}