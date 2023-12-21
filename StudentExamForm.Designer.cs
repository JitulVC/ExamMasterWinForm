namespace ExamMaster
{
    partial class StudentExamForm
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "AWS Associate Solution Architect", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "180", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExamForm));
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "2023-11-04 8:20", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "2", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "705", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Pass", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "60", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "56", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "2023-10-21 14:10", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "1", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "675", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Fail", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "60", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "51", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            groupBoxExams = new GroupBox();
            listViewExams = new ListView();
            columnHeaderExams = new ColumnHeader();
            columnHeaderDuration = new ColumnHeader();
            toolTipButton = new ToolTip(components);
            buttonStart = new Button();
            buttonClose = new Button();
            groupBoxExamData = new GroupBox();
            labelExamName = new Label();
            textBoxExamName = new TextBox();
            hlabelId = new Label();
            groupBoxExamHistory = new GroupBox();
            listViewExamHistory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            labelHint = new Label();
            textBoxTotalScore = new TextBox();
            labelTotalScore = new Label();
            labelPassingScore = new Label();
            textBoxPassingScore = new TextBox();
            labelDurationUnits = new Label();
            textBoxNoOfQuestions = new TextBox();
            labelNoOfQuestioms = new Label();
            textBoxDuration = new TextBox();
            labelDuration = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxExams.SuspendLayout();
            groupBoxExamData.SuspendLayout();
            groupBoxExamHistory.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxExams
            // 
            groupBoxExams.Controls.Add(listViewExams);
            groupBoxExams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxExams.Location = new Point(13, 79);
            groupBoxExams.Margin = new Padding(4, 5, 4, 5);
            groupBoxExams.Name = "groupBoxExams";
            groupBoxExams.Padding = new Padding(4, 5, 4, 5);
            groupBoxExams.Size = new Size(560, 609);
            groupBoxExams.TabIndex = 12;
            groupBoxExams.TabStop = false;
            groupBoxExams.Text = "Exams";
            // 
            // listViewExams
            // 
            listViewExams.Columns.AddRange(new ColumnHeader[] { columnHeaderExams, columnHeaderDuration });
            listViewExams.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExams.FullRowSelect = true;
            listViewExams.GridLines = true;
            listViewExams.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewExams.Location = new Point(11, 34);
            listViewExams.Margin = new Padding(4, 5, 4, 5);
            listViewExams.Name = "listViewExams";
            listViewExams.Size = new Size(541, 565);
            listViewExams.TabIndex = 0;
            listViewExams.UseCompatibleStateImageBehavior = false;
            listViewExams.View = View.Details;
            listViewExams.Click += listViewExams_Click;
            // 
            // columnHeaderExams
            // 
            columnHeaderExams.Text = "Exam";
            columnHeaderExams.Width = 405;
            // 
            // columnHeaderDuration
            // 
            columnHeaderDuration.Text = "Duration";
            columnHeaderDuration.TextAlign = HorizontalAlignment.Center;
            columnHeaderDuration.Width = 95;
            // 
            // buttonStart
            // 
            buttonStart.Image = (Image)resources.GetObject("buttonStart.Image");
            buttonStart.Location = new Point(793, 542);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(55, 58);
            buttonStart.TabIndex = 21;
            toolTipButton.SetToolTip(buttonStart, "Start Exam");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1419, -1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 14;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupBoxExamData
            // 
            groupBoxExamData.Controls.Add(labelExamName);
            groupBoxExamData.Controls.Add(textBoxExamName);
            groupBoxExamData.Controls.Add(hlabelId);
            groupBoxExamData.Controls.Add(groupBoxExamHistory);
            groupBoxExamData.Controls.Add(labelHint);
            groupBoxExamData.Controls.Add(buttonStart);
            groupBoxExamData.Controls.Add(textBoxTotalScore);
            groupBoxExamData.Controls.Add(labelTotalScore);
            groupBoxExamData.Controls.Add(labelPassingScore);
            groupBoxExamData.Controls.Add(textBoxPassingScore);
            groupBoxExamData.Controls.Add(labelDurationUnits);
            groupBoxExamData.Controls.Add(textBoxNoOfQuestions);
            groupBoxExamData.Controls.Add(labelNoOfQuestioms);
            groupBoxExamData.Controls.Add(textBoxDuration);
            groupBoxExamData.Controls.Add(labelDuration);
            groupBoxExamData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxExamData.Location = new Point(593, 79);
            groupBoxExamData.Name = "groupBoxExamData";
            groupBoxExamData.Size = new Size(871, 609);
            groupBoxExamData.TabIndex = 13;
            groupBoxExamData.TabStop = false;
            groupBoxExamData.Text = "Exam Info";
            // 
            // labelExamName
            // 
            labelExamName.AutoSize = true;
            labelExamName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamName.Location = new Point(34, 30);
            labelExamName.Name = "labelExamName";
            labelExamName.Size = new Size(125, 28);
            labelExamName.TabIndex = 29;
            labelExamName.Text = "Exam Name:";
            // 
            // textBoxExamName
            // 
            textBoxExamName.Location = new Point(27, 59);
            textBoxExamName.Name = "textBoxExamName";
            textBoxExamName.ReadOnly = true;
            textBoxExamName.Size = new Size(619, 34);
            textBoxExamName.TabIndex = 28;
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(34, 572);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 27;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // groupBoxExamHistory
            // 
            groupBoxExamHistory.Controls.Add(listViewExamHistory);
            groupBoxExamHistory.Location = new Point(27, 166);
            groupBoxExamHistory.Name = "groupBoxExamHistory";
            groupBoxExamHistory.Size = new Size(821, 370);
            groupBoxExamHistory.TabIndex = 24;
            groupBoxExamHistory.TabStop = false;
            groupBoxExamHistory.Text = "Exam History";
            // 
            // listViewExamHistory
            // 
            listViewExamHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewExamHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExamHistory.FullRowSelect = true;
            listViewExamHistory.GridLines = true;
            listViewExamHistory.Items.AddRange(new ListViewItem[] { listViewItem2, listViewItem3 });
            listViewExamHistory.Location = new Point(7, 35);
            listViewExamHistory.Margin = new Padding(4, 5, 4, 5);
            listViewExamHistory.Name = "listViewExamHistory";
            listViewExamHistory.Size = new Size(807, 327);
            listViewExamHistory.TabIndex = 13;
            listViewExamHistory.UseCompatibleStateImageBehavior = false;
            listViewExamHistory.View = View.Details;
            listViewExamHistory.DoubleClick += listViewExamHistory_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Attempted On";
            columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Attempt No.";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Score";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Result";
            columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Answered Questions";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Correct Answers";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHint.Location = new Point(27, 539);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(241, 25);
            labelHint.TabIndex = 22;
            labelHint.Text = "Double click to Review Exam";
            // 
            // textBoxTotalScore
            // 
            textBoxTotalScore.Location = new Point(480, 126);
            textBoxTotalScore.Name = "textBoxTotalScore";
            textBoxTotalScore.ReadOnly = true;
            textBoxTotalScore.Size = new Size(166, 34);
            textBoxTotalScore.TabIndex = 18;
            textBoxTotalScore.TextAlign = HorizontalAlignment.Right;
            // 
            // labelTotalScore
            // 
            labelTotalScore.AutoSize = true;
            labelTotalScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalScore.Location = new Point(480, 98);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new Size(116, 28);
            labelTotalScore.TabIndex = 15;
            labelTotalScore.Text = "Total Score:";
            // 
            // labelPassingScore
            // 
            labelPassingScore.AutoSize = true;
            labelPassingScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassingScore.Location = new Point(682, 98);
            labelPassingScore.Name = "labelPassingScore";
            labelPassingScore.Size = new Size(141, 28);
            labelPassingScore.TabIndex = 17;
            labelPassingScore.Text = "Passing Score:";
            // 
            // textBoxPassingScore
            // 
            textBoxPassingScore.Location = new Point(682, 126);
            textBoxPassingScore.Name = "textBoxPassingScore";
            textBoxPassingScore.ReadOnly = true;
            textBoxPassingScore.Size = new Size(166, 34);
            textBoxPassingScore.TabIndex = 16;
            textBoxPassingScore.TextAlign = HorizontalAlignment.Right;
            // 
            // labelDurationUnits
            // 
            labelDurationUnits.AutoSize = true;
            labelDurationUnits.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDurationUnits.Location = new Point(175, 132);
            labelDurationUnits.Name = "labelDurationUnits";
            labelDurationUnits.Size = new Size(70, 28);
            labelDurationUnits.TabIndex = 11;
            labelDurationUnits.Text = "(mins)";
            // 
            // textBoxNoOfQuestions
            // 
            textBoxNoOfQuestions.Location = new Point(255, 126);
            textBoxNoOfQuestions.Name = "textBoxNoOfQuestions";
            textBoxNoOfQuestions.ReadOnly = true;
            textBoxNoOfQuestions.Size = new Size(166, 34);
            textBoxNoOfQuestions.TabIndex = 2;
            textBoxNoOfQuestions.TextAlign = HorizontalAlignment.Right;
            // 
            // labelNoOfQuestioms
            // 
            labelNoOfQuestioms.AutoSize = true;
            labelNoOfQuestioms.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoOfQuestioms.Location = new Point(255, 98);
            labelNoOfQuestioms.Name = "labelNoOfQuestioms";
            labelNoOfQuestioms.Size = new Size(172, 28);
            labelNoOfQuestioms.TabIndex = 2;
            labelNoOfQuestioms.Text = "No. of Questions:";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(27, 126);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.ReadOnly = true;
            textBoxDuration.Size = new Size(142, 34);
            textBoxDuration.TabIndex = 1;
            textBoxDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDuration.Location = new Point(27, 98);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(96, 28);
            labelDuration.TabIndex = 0;
            labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(24, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(541, 34);
            textBoxName.TabIndex = 16;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(24, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(148, 28);
            labelName.TabIndex = 15;
            labelName.Text = "Student Name:";
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 699);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1473, 35);
            statusStripMsg.TabIndex = 17;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // StudentExamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 734);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(textBoxName);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxExamData);
            Controls.Add(labelName);
            Controls.Add(groupBoxExams);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StudentExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enroll Exam";
            groupBoxExams.ResumeLayout(false);
            groupBoxExamData.ResumeLayout(false);
            groupBoxExamData.PerformLayout();
            groupBoxExamHistory.ResumeLayout(false);
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxExams;
        private ListView listViewExams;
        private ColumnHeader columnHeaderExams;
        private ColumnHeader columnHeaderDuration;
        private ToolTip toolTipButton;
        private GroupBox groupBoxExamData;
        private Label labelHint;
        private Button buttonStart;
        private TextBox textBoxTotalScore;
        private Label labelTotalScore;
        private Label labelPassingScore;
        private TextBox textBoxPassingScore;
        private Label labelDurationUnits;
        private TextBox textBoxNoOfQuestions;
        private Label labelNoOfQuestioms;
        private TextBox textBoxDuration;
        private Label labelDuration;
        private GroupBox groupBoxExamHistory;
        private ListView listViewExamHistory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button buttonClose;
        private TextBox textBoxName;
        private Label labelName;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
        private Label labelExamName;
        private TextBox textBoxExamName;
    }
}