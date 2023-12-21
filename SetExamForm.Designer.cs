namespace ExamMaster
{
    partial class SetExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetExamForm));
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "1..", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "How do you allow S3 bucket to an anonymous user?", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "2.", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "How do you allow an EC2 with private IP address to receive updates from Internet?", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "AWS Associate Solution Architect", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "26-11-2023", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            groupBoxExamData = new GroupBox();
            buttonAdd = new Button();
            textBoxExamName = new TextBox();
            labelExamName = new Label();
            hlabelId = new Label();
            labelHint = new Label();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            textBoxTotalScore = new TextBox();
            labelTotalScore = new Label();
            labelPassingScore = new Label();
            textBoxPassingScore = new TextBox();
            listViewExamQuestions = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            labelDurationUnits = new Label();
            textBoxNoOfQuestions = new TextBox();
            labelNoOfQuestioms = new Label();
            textBoxDuration = new TextBox();
            labelDuration = new Label();
            groupBoxExams = new GroupBox();
            listViewExams = new ListView();
            columnHeaderExams = new ColumnHeader();
            columnHeaderNoOfAttempts = new ColumnHeader();
            toolTipButton = new ToolTip(components);
            buttonClose = new Button();
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxExamData.SuspendLayout();
            groupBoxExams.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxExamData
            // 
            groupBoxExamData.Controls.Add(buttonAdd);
            groupBoxExamData.Controls.Add(textBoxExamName);
            groupBoxExamData.Controls.Add(labelExamName);
            groupBoxExamData.Controls.Add(hlabelId);
            groupBoxExamData.Controls.Add(labelHint);
            groupBoxExamData.Controls.Add(buttonDelete);
            groupBoxExamData.Controls.Add(buttonClear);
            groupBoxExamData.Controls.Add(buttonSave);
            groupBoxExamData.Controls.Add(textBoxTotalScore);
            groupBoxExamData.Controls.Add(labelTotalScore);
            groupBoxExamData.Controls.Add(labelPassingScore);
            groupBoxExamData.Controls.Add(textBoxPassingScore);
            groupBoxExamData.Controls.Add(listViewExamQuestions);
            groupBoxExamData.Controls.Add(labelDurationUnits);
            groupBoxExamData.Controls.Add(textBoxNoOfQuestions);
            groupBoxExamData.Controls.Add(labelNoOfQuestioms);
            groupBoxExamData.Controls.Add(textBoxDuration);
            groupBoxExamData.Controls.Add(labelDuration);
            groupBoxExamData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxExamData.Location = new Point(703, 62);
            groupBoxExamData.Name = "groupBoxExamData";
            groupBoxExamData.Size = new Size(838, 630);
            groupBoxExamData.TabIndex = 12;
            groupBoxExamData.TabStop = false;
            groupBoxExamData.Text = "Exam Info";
            // 
            // buttonAdd
            // 
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(515, 562);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(55, 58);
            buttonAdd.TabIndex = 26;
            toolTipButton.SetToolTip(buttonAdd, "Add Question");
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxExamName
            // 
            textBoxExamName.Location = new Point(152, 33);
            textBoxExamName.MaxLength = 60;
            textBoxExamName.Name = "textBoxExamName";
            textBoxExamName.Size = new Size(670, 34);
            textBoxExamName.TabIndex = 25;
            // 
            // labelExamName
            // 
            labelExamName.AutoSize = true;
            labelExamName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamName.Location = new Point(27, 36);
            labelExamName.Name = "labelExamName";
            labelExamName.Size = new Size(125, 28);
            labelExamName.TabIndex = 24;
            labelExamName.Text = "Exam Name:";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(27, 591);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 23;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHint.Location = new Point(27, 562);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(349, 25);
            labelHint.TabIndex = 22;
            labelHint.Text = "Double click Question to open detail form.";
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(767, 562);
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
            buttonClear.Location = new Point(665, 562);
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
            buttonSave.Location = new Point(591, 562);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 19;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxTotalScore
            // 
            textBoxTotalScore.Location = new Point(458, 112);
            textBoxTotalScore.MaxLength = 3;
            textBoxTotalScore.Name = "textBoxTotalScore";
            textBoxTotalScore.Size = new Size(166, 34);
            textBoxTotalScore.TabIndex = 18;
            textBoxTotalScore.TextAlign = HorizontalAlignment.Right;
            textBoxTotalScore.KeyPress += textBoxTotalScore_KeyPress;
            // 
            // labelTotalScore
            // 
            labelTotalScore.AutoSize = true;
            labelTotalScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalScore.Location = new Point(458, 84);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new Size(116, 28);
            labelTotalScore.TabIndex = 15;
            labelTotalScore.Text = "Total Score:";
            // 
            // labelPassingScore
            // 
            labelPassingScore.AutoSize = true;
            labelPassingScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassingScore.Location = new Point(656, 84);
            labelPassingScore.Name = "labelPassingScore";
            labelPassingScore.Size = new Size(141, 28);
            labelPassingScore.TabIndex = 17;
            labelPassingScore.Text = "Passing Score:";
            // 
            // textBoxPassingScore
            // 
            textBoxPassingScore.Location = new Point(656, 112);
            textBoxPassingScore.MaxLength = 3;
            textBoxPassingScore.Name = "textBoxPassingScore";
            textBoxPassingScore.Size = new Size(166, 34);
            textBoxPassingScore.TabIndex = 16;
            textBoxPassingScore.TextAlign = HorizontalAlignment.Right;
            textBoxPassingScore.KeyPress += textBoxPassingScore_KeyPress;
            // 
            // listViewExamQuestions
            // 
            listViewExamQuestions.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            listViewExamQuestions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExamQuestions.FullRowSelect = true;
            listViewExamQuestions.GridLines = true;
            listViewExamQuestions.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewExamQuestions.Location = new Point(27, 154);
            listViewExamQuestions.Margin = new Padding(4, 5, 4, 5);
            listViewExamQuestions.Name = "listViewExamQuestions";
            listViewExamQuestions.Size = new Size(795, 403);
            listViewExamQuestions.TabIndex = 12;
            listViewExamQuestions.UseCompatibleStateImageBehavior = false;
            listViewExamQuestions.View = View.Details;
            listViewExamQuestions.DoubleClick += listViewExamQuestions_DoubleClick;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "#";
            columnHeader2.Width = 40;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Question";
            columnHeader1.Width = 720;
            // 
            // labelDurationUnits
            // 
            labelDurationUnits.AutoSize = true;
            labelDurationUnits.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDurationUnits.Location = new Point(175, 118);
            labelDurationUnits.Name = "labelDurationUnits";
            labelDurationUnits.Size = new Size(70, 28);
            labelDurationUnits.TabIndex = 11;
            labelDurationUnits.Text = "(mins)";
            // 
            // textBoxNoOfQuestions
            // 
            textBoxNoOfQuestions.Location = new Point(255, 112);
            textBoxNoOfQuestions.MaxLength = 3;
            textBoxNoOfQuestions.Name = "textBoxNoOfQuestions";
            textBoxNoOfQuestions.Size = new Size(166, 34);
            textBoxNoOfQuestions.TabIndex = 2;
            textBoxNoOfQuestions.TextAlign = HorizontalAlignment.Right;
            textBoxNoOfQuestions.KeyPress += textBoxNoOfQuestions_KeyPress;
            // 
            // labelNoOfQuestioms
            // 
            labelNoOfQuestioms.AutoSize = true;
            labelNoOfQuestioms.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNoOfQuestioms.Location = new Point(255, 84);
            labelNoOfQuestioms.Name = "labelNoOfQuestioms";
            labelNoOfQuestioms.Size = new Size(172, 28);
            labelNoOfQuestioms.TabIndex = 2;
            labelNoOfQuestioms.Text = "No. of Questions:";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(27, 112);
            textBoxDuration.MaxLength = 3;
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(142, 34);
            textBoxDuration.TabIndex = 1;
            textBoxDuration.TextAlign = HorizontalAlignment.Right;
            textBoxDuration.KeyPress += textBoxDuration_KeyPress;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDuration.Location = new Point(27, 84);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(96, 28);
            labelDuration.TabIndex = 0;
            labelDuration.Text = "Duration:";
            // 
            // groupBoxExams
            // 
            groupBoxExams.Controls.Add(listViewExams);
            groupBoxExams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxExams.Location = new Point(14, 62);
            groupBoxExams.Margin = new Padding(4, 5, 4, 5);
            groupBoxExams.Name = "groupBoxExams";
            groupBoxExams.Padding = new Padding(4, 5, 4, 5);
            groupBoxExams.Size = new Size(660, 630);
            groupBoxExams.TabIndex = 11;
            groupBoxExams.TabStop = false;
            groupBoxExams.Text = "Exams";
            // 
            // listViewExams
            // 
            listViewExams.Columns.AddRange(new ColumnHeader[] { columnHeaderExams, columnHeaderNoOfAttempts });
            listViewExams.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExams.FullRowSelect = true;
            listViewExams.GridLines = true;
            listViewExams.Items.AddRange(new ListViewItem[] { listViewItem3 });
            listViewExams.Location = new Point(11, 34);
            listViewExams.Margin = new Padding(4, 5, 4, 5);
            listViewExams.Name = "listViewExams";
            listViewExams.Size = new Size(641, 537);
            listViewExams.TabIndex = 0;
            listViewExams.UseCompatibleStateImageBehavior = false;
            listViewExams.View = View.Details;
            listViewExams.Click += listViewExams_Click;
            // 
            // columnHeaderExams
            // 
            columnHeaderExams.Text = "Exam";
            columnHeaderExams.Width = 440;
            // 
            // columnHeaderNoOfAttempts
            // 
            columnHeaderNoOfAttempts.Text = "Last Updated";
            columnHeaderNoOfAttempts.TextAlign = HorizontalAlignment.Center;
            columnHeaderNoOfAttempts.Width = 150;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(1532, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 13;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 704);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1588, 35);
            statusStripMsg.TabIndex = 16;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // SetExamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 739);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(groupBoxExamData);
            Controls.Add(groupBoxExams);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SetExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Exam";
            groupBoxExamData.ResumeLayout(false);
            groupBoxExamData.PerformLayout();
            groupBoxExams.ResumeLayout(false);
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxExamData;
        private ToolTip toolTipButton;
        private TextBox textBoxNoOfQuestions;
        private Label labelNoOfQuestioms;
        private TextBox textBoxDuration;
        private Label labelDuration;
        private GroupBox groupBoxExams;
        private ListView listViewExams;
        private ColumnHeader columnHeaderExams;
        private ColumnHeader columnHeaderNoOfAttempts;
        private Button buttonClose;
        private Label labelDurationUnits;
        private TextBox textBoxTotalScore;
        private Label labelTotalScore;
        private Label labelPassingScore;
        private TextBox textBoxPassingScore;
        private ListView listViewExamQuestions;
        private ColumnHeader columnHeader2;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private Label labelHint;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private Label hlabelId;
        private TextBox textBoxExamName;
        private Label labelExamName;
        private ColumnHeader columnHeader1;
        private Button buttonAdd;
    }
}