namespace ExamMaster
{
    partial class UserForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "beckschng", "Rebecca Chng" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            groupBoxUsers = new GroupBox();
            listViewUsers = new ListView();
            columnHeaderUserAccount = new ColumnHeader();
            columnHeaderUserName = new ColumnHeader();
            groupBoxUserData = new GroupBox();
            hlabelId = new Label();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            labelAPIKey = new Label();
            comboBoxRole = new ComboBox();
            textBoxAPIKey = new TextBox();
            labelRole = new Label();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            textBoxUserAccount = new TextBox();
            labelUserAccount = new Label();
            toolTipButton = new ToolTip(components);
            buttonClose = new Button();
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxUsers.SuspendLayout();
            groupBoxUserData.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsers
            // 
            groupBoxUsers.Controls.Add(listViewUsers);
            groupBoxUsers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxUsers.Location = new Point(17, 54);
            groupBoxUsers.Margin = new Padding(4, 5, 4, 5);
            groupBoxUsers.Name = "groupBoxUsers";
            groupBoxUsers.Padding = new Padding(4, 5, 4, 5);
            groupBoxUsers.Size = new Size(660, 586);
            groupBoxUsers.TabIndex = 0;
            groupBoxUsers.TabStop = false;
            groupBoxUsers.Text = "Users";
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeaderUserAccount, columnHeaderUserName });
            listViewUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewUsers.Location = new Point(9, 33);
            listViewUsers.Margin = new Padding(4, 5, 4, 5);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(641, 537);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            listViewUsers.Click += listViewUsers_Click;
            // 
            // columnHeaderUserAccount
            // 
            columnHeaderUserAccount.Text = "User Account";
            columnHeaderUserAccount.Width = 230;
            // 
            // columnHeaderUserName
            // 
            columnHeaderUserName.Text = "User Name";
            columnHeaderUserName.Width = 380;
            // 
            // groupBoxUserData
            // 
            groupBoxUserData.Controls.Add(hlabelId);
            groupBoxUserData.Controls.Add(buttonDelete);
            groupBoxUserData.Controls.Add(buttonClear);
            groupBoxUserData.Controls.Add(buttonSave);
            groupBoxUserData.Controls.Add(labelAPIKey);
            groupBoxUserData.Controls.Add(comboBoxRole);
            groupBoxUserData.Controls.Add(textBoxAPIKey);
            groupBoxUserData.Controls.Add(labelRole);
            groupBoxUserData.Controls.Add(textBoxUserName);
            groupBoxUserData.Controls.Add(labelUserName);
            groupBoxUserData.Controls.Add(textBoxUserAccount);
            groupBoxUserData.Controls.Add(labelUserAccount);
            groupBoxUserData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxUserData.Location = new Point(703, 54);
            groupBoxUserData.Name = "groupBoxUserData";
            groupBoxUserData.Size = new Size(546, 466);
            groupBoxUserData.TabIndex = 1;
            groupBoxUserData.TabStop = false;
            groupBoxUserData.Text = "User Info";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(27, 422);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 11;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(449, 392);
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
            buttonClear.Location = new Point(347, 392);
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
            buttonSave.Location = new Point(273, 392);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 8;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelAPIKey
            // 
            labelAPIKey.AutoSize = true;
            labelAPIKey.Location = new Point(27, 309);
            labelAPIKey.Name = "labelAPIKey";
            labelAPIKey.Size = new Size(82, 28);
            labelAPIKey.TabIndex = 7;
            labelAPIKey.Text = "API Key:";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(27, 246);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(389, 36);
            comboBoxRole.TabIndex = 3;
            // 
            // textBoxAPIKey
            // 
            textBoxAPIKey.Location = new Point(27, 337);
            textBoxAPIKey.MaxLength = 100;
            textBoxAPIKey.Name = "textBoxAPIKey";
            textBoxAPIKey.Size = new Size(477, 34);
            textBoxAPIKey.TabIndex = 4;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(27, 218);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(54, 28);
            labelRole.TabIndex = 4;
            labelRole.Text = "Role:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(27, 160);
            textBoxUserName.MaxLength = 60;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(477, 34);
            textBoxUserName.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(27, 132);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(112, 28);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "User Name:";
            // 
            // textBoxUserAccount
            // 
            textBoxUserAccount.Location = new Point(27, 78);
            textBoxUserAccount.MaxLength = 40;
            textBoxUserAccount.Name = "textBoxUserAccount";
            textBoxUserAccount.Size = new Size(393, 34);
            textBoxUserAccount.TabIndex = 1;
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Location = new Point(27, 50);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(132, 28);
            labelUserAccount.TabIndex = 0;
            labelUserAccount.Text = "User Account:";
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1203, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 10;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 649);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1261, 35);
            statusStripMsg.TabIndex = 12;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 684);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxUserData);
            Controls.Add(groupBoxUsers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management";
            groupBoxUsers.ResumeLayout(false);
            groupBoxUserData.ResumeLayout(false);
            groupBoxUserData.PerformLayout();
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUsers;
        private ListView listViewUsers;
        private ColumnHeader columnHeaderUserAccount;
        private ColumnHeader columnHeaderUserName;
        private GroupBox groupBoxUserData;
        private Label labelAPIKey;
        private ComboBox comboBoxRole;
        private TextBox textBoxAPIKey;
        private Label labelRole;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private TextBox textBoxUserAccount;
        private Label labelUserAccount;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private ToolTip toolTipButton;
        private Button buttonClose;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
    }
}