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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "How do you allow S3 bucket to an anonymous user?", "84" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "How do you allow an EC2 with private IP address to receive updates from Internet?" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "AWS Associate Solution Architect", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "8", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            groupBoxExamData = new GroupBox();
            labelMsg = new Label();
            labelHint = new Label();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            textBoxTotalScore = new TextBox();
            labelTotalScore = new Label();
            labelPassingScore = new Label();
            textBoxPassingScore = new TextBox();
            listViewExamQuestions = new ListView();
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
            groupBoxExamData.SuspendLayout();
            groupBoxExams.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxExamData
            // 
            groupBoxExamData.Controls.Add(labelMsg);
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
            groupBoxExamData.Size = new Size(838, 588);
            groupBoxExamData.TabIndex = 12;
            groupBoxExamData.TabStop = false;
            groupBoxExamData.Text = "Exam Info";
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.Location = new Point(32, 551);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(0, 28);
            labelMsg.TabIndex = 23;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelHint.Location = new Point(27, 487);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(332, 25);
            labelHint.TabIndex = 22;
            labelHint.Text = "Double click Question to open detail form.";
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(767, 513);
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
            buttonClear.Location = new Point(665, 513);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 58);
            buttonClear.TabIndex = 20;
            toolTipButton.SetToolTip(buttonClear, "Clear");
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(591, 513);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 19;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxTotalScore
            // 
            textBoxTotalScore.Location = new Point(458, 63);
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
            labelTotalScore.Location = new Point(458, 35);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new Size(112, 28);
            labelTotalScore.TabIndex = 15;
            labelTotalScore.Text = "Total Score:";
            // 
            // labelPassingScore
            // 
            labelPassingScore.AutoSize = true;
            labelPassingScore.Location = new Point(656, 35);
            labelPassingScore.Name = "labelPassingScore";
            labelPassingScore.Size = new Size(134, 28);
            labelPassingScore.TabIndex = 17;
            labelPassingScore.Text = "Passing Score:";
            // 
            // textBoxPassingScore
            // 
            textBoxPassingScore.Location = new Point(656, 63);
            textBoxPassingScore.MaxLength = 3;
            textBoxPassingScore.Name = "textBoxPassingScore";
            textBoxPassingScore.Size = new Size(166, 34);
            textBoxPassingScore.TabIndex = 16;
            textBoxPassingScore.TextAlign = HorizontalAlignment.Right;
            textBoxPassingScore.KeyPress += textBoxPassingScore_KeyPress;
            // 
            // listViewExamQuestions
            // 
            listViewExamQuestions.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewExamQuestions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewExamQuestions.FullRowSelect = true;
            listViewExamQuestions.GridLines = true;
            listViewExamQuestions.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewExamQuestions.Location = new Point(27, 105);
            listViewExamQuestions.Margin = new Padding(4, 5, 4, 5);
            listViewExamQuestions.Name = "listViewExamQuestions";
            listViewExamQuestions.Size = new Size(795, 377);
            listViewExamQuestions.TabIndex = 12;
            listViewExamQuestions.UseCompatibleStateImageBehavior = false;
            listViewExamQuestions.View = View.Details;
            listViewExamQuestions.DoubleClick += listViewExamQuestions_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Question";
            columnHeader1.Width = 720;
            // 
            // labelDurationUnits
            // 
            labelDurationUnits.AutoSize = true;
            labelDurationUnits.Location = new Point(175, 69);
            labelDurationUnits.Name = "labelDurationUnits";
            labelDurationUnits.Size = new Size(65, 28);
            labelDurationUnits.TabIndex = 11;
            labelDurationUnits.Text = "(mins)";
            // 
            // textBoxNoOfQuestions
            // 
            textBoxNoOfQuestions.Location = new Point(255, 63);
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
            labelNoOfQuestioms.Location = new Point(255, 35);
            labelNoOfQuestioms.Name = "labelNoOfQuestioms";
            labelNoOfQuestioms.Size = new Size(162, 28);
            labelNoOfQuestioms.TabIndex = 2;
            labelNoOfQuestioms.Text = "No. of Questions:";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(27, 63);
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
            labelDuration.Location = new Point(27, 35);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(93, 28);
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
            groupBoxExams.Size = new Size(660, 588);
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
            // 
            // columnHeaderExams
            // 
            columnHeaderExams.Text = "Exam";
            columnHeaderExams.Width = 405;
            // 
            // columnHeaderNoOfAttempts
            // 
            columnHeaderNoOfAttempts.Text = "No. of Attempts";
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
            // SetExamForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 661);
            ControlBox = false;
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
            ResumeLayout(false);
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
        private ColumnHeader columnHeader1;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private Label labelMsg;
        private Label labelHint;
    }
}