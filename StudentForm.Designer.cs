namespace ExamMaster
{
    partial class StudentForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Lucas Chan", "84" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Rachel Wong" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "AWS Associate Certification Exam", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "680", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "2", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "2023-11-02", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "Google Cloud Associate Engineer Exam", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "702", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "1", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "2023-10-23", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            groupBoxStudents = new GroupBox();
            listViewStudents = new ListView();
            columnHeaderStudents = new ColumnHeader();
            groupBoxStudentData = new GroupBox();
            hlabelId = new Label();
            comboBoxUserAccount = new ComboBox();
            groupBoxExamHistory = new GroupBox();
            listViewExamHistory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            labelUserAccount = new Label();
            textBoxStudentName = new TextBox();
            labelName = new Label();
            toolTipButton = new ToolTip(components);
            buttonClose = new Button();
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxStudents.SuspendLayout();
            groupBoxStudentData.SuspendLayout();
            groupBoxExamHistory.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudents
            // 
            groupBoxStudents.Controls.Add(listViewStudents);
            groupBoxStudents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxStudents.Location = new Point(13, 53);
            groupBoxStudents.Margin = new Padding(4, 5, 4, 5);
            groupBoxStudents.Name = "groupBoxStudents";
            groupBoxStudents.Padding = new Padding(4, 5, 4, 5);
            groupBoxStudents.Size = new Size(441, 588);
            groupBoxStudents.TabIndex = 12;
            groupBoxStudents.TabStop = false;
            groupBoxStudents.Text = "Students";
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new ColumnHeader[] { columnHeaderStudents });
            listViewStudents.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewStudents.FullRowSelect = true;
            listViewStudents.GridLines = true;
            listViewStudents.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewStudents.Location = new Point(11, 34);
            listViewStudents.Margin = new Padding(4, 5, 4, 5);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new Size(417, 537);
            listViewStudents.TabIndex = 0;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            listViewStudents.Click += listViewStudents_Click;
            // 
            // columnHeaderStudents
            // 
            columnHeaderStudents.Text = "Student Name";
            columnHeaderStudents.Width = 380;
            // 
            // groupBoxStudentData
            // 
            groupBoxStudentData.Controls.Add(hlabelId);
            groupBoxStudentData.Controls.Add(comboBoxUserAccount);
            groupBoxStudentData.Controls.Add(groupBoxExamHistory);
            groupBoxStudentData.Controls.Add(buttonDelete);
            groupBoxStudentData.Controls.Add(buttonClear);
            groupBoxStudentData.Controls.Add(buttonSave);
            groupBoxStudentData.Controls.Add(labelUserAccount);
            groupBoxStudentData.Controls.Add(textBoxStudentName);
            groupBoxStudentData.Controls.Add(labelName);
            groupBoxStudentData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxStudentData.Location = new Point(474, 53);
            groupBoxStudentData.Name = "groupBoxStudentData";
            groupBoxStudentData.Size = new Size(963, 588);
            groupBoxStudentData.TabIndex = 13;
            groupBoxStudentData.TabStop = false;
            groupBoxStudentData.Text = "Student Info";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(28, 550);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 26;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // comboBoxUserAccount
            // 
            comboBoxUserAccount.FormattingEnabled = true;
            comboBoxUserAccount.Location = new Point(589, 61);
            comboBoxUserAccount.Name = "comboBoxUserAccount";
            comboBoxUserAccount.Size = new Size(355, 36);
            comboBoxUserAccount.TabIndex = 25;
            // 
            // groupBoxExamHistory
            // 
            groupBoxExamHistory.Controls.Add(listViewExamHistory);
            groupBoxExamHistory.Location = new Point(27, 105);
            groupBoxExamHistory.Name = "groupBoxExamHistory";
            groupBoxExamHistory.Size = new Size(917, 407);
            groupBoxExamHistory.TabIndex = 24;
            groupBoxExamHistory.TabStop = false;
            groupBoxExamHistory.Text = "Exam History";
            // 
            // listViewExamHistory
            // 
            listViewExamHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewExamHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExamHistory.FullRowSelect = true;
            listViewExamHistory.GridLines = true;
            listViewExamHistory.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listViewExamHistory.Location = new Point(16, 32);
            listViewExamHistory.Margin = new Padding(4, 5, 4, 5);
            listViewExamHistory.Name = "listViewExamHistory";
            listViewExamHistory.Size = new Size(884, 367);
            listViewExamHistory.TabIndex = 13;
            listViewExamHistory.UseCompatibleStateImageBehavior = false;
            listViewExamHistory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Exam";
            columnHeader1.Width = 475;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Atmp.No.";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Exam Date";
            columnHeader4.Width = 170;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(889, 518);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(55, 58);
            buttonDelete.TabIndex = 21;
            toolTipButton.SetToolTip(buttonDelete, "Delete");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(786, 519);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 58);
            buttonClear.TabIndex = 20;
            toolTipButton.SetToolTip(buttonClear, "Clear");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(712, 519);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 19;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserAccount.Location = new Point(589, 35);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(138, 28);
            labelUserAccount.TabIndex = 17;
            labelUserAccount.Text = "User Account:";
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Location = new Point(28, 63);
            textBoxStudentName.MaxLength = 60;
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(533, 34);
            textBoxStudentName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(27, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 28);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1395, -3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 14;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 654);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1449, 35);
            statusStripMsg.TabIndex = 15;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 689);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxStudentData);
            Controls.Add(groupBoxStudents);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            groupBoxStudents.ResumeLayout(false);
            groupBoxStudentData.ResumeLayout(false);
            groupBoxStudentData.PerformLayout();
            groupBoxExamHistory.ResumeLayout(false);
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxStudents;
        private ListView listViewStudents;
        private ColumnHeader columnHeaderStudents;
        private GroupBox groupBoxStudentData;
        private GroupBox groupBoxExamHistory;
        private ListView listViewExamHistory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private Label labelUserAccount;
        private TextBox textBoxStudentName;
        private Label labelName;
        private ToolTip toolTipButton;
        private Button buttonClose;
        private ComboBox comboBoxUserAccount;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
    }
}