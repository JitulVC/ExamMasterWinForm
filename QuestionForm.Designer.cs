namespace ExamMaster
{
    partial class QuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            groupBoxQuestion = new GroupBox();
            textBoxQuestion = new TextBox();
            groupBoxAnswer = new GroupBox();
            textBoxMarks = new TextBox();
            labelMarks = new Label();
            checkBoxAnswer4 = new CheckBox();
            checkBoxAnswer3 = new CheckBox();
            checkBoxAnswer2 = new CheckBox();
            checkBoxAnswer1 = new CheckBox();
            labelCorrectAnswer = new Label();
            labelFour = new Label();
            labelThree = new Label();
            labelTwo = new Label();
            labelOne = new Label();
            textBoxAnswer4 = new TextBox();
            textBoxAnswer3 = new TextBox();
            textBoxAnswer2 = new TextBox();
            textBoxAnswer1 = new TextBox();
            groupBoxAnswerType = new GroupBox();
            radioButtonMultiChoice = new RadioButton();
            radioButtonSingleChoice = new RadioButton();
            buttonDelete = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            toolTipButton = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxQuestion.SuspendLayout();
            groupBoxAnswer.SuspendLayout();
            groupBoxAnswerType.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxQuestion
            // 
            groupBoxQuestion.Controls.Add(textBoxQuestion);
            groupBoxQuestion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxQuestion.Location = new Point(20, 15);
            groupBoxQuestion.Name = "groupBoxQuestion";
            groupBoxQuestion.Size = new Size(1193, 246);
            groupBoxQuestion.TabIndex = 0;
            groupBoxQuestion.TabStop = false;
            groupBoxQuestion.Text = "Question";
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuestion.Location = new Point(16, 35);
            textBoxQuestion.MaxLength = 2000;
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ScrollBars = ScrollBars.Vertical;
            textBoxQuestion.Size = new Size(1162, 194);
            textBoxQuestion.TabIndex = 1;
            textBoxQuestion.TabStop = false;
            // 
            // groupBoxAnswer
            // 
            groupBoxAnswer.Controls.Add(textBoxMarks);
            groupBoxAnswer.Controls.Add(labelMarks);
            groupBoxAnswer.Controls.Add(checkBoxAnswer4);
            groupBoxAnswer.Controls.Add(checkBoxAnswer3);
            groupBoxAnswer.Controls.Add(checkBoxAnswer2);
            groupBoxAnswer.Controls.Add(checkBoxAnswer1);
            groupBoxAnswer.Controls.Add(labelCorrectAnswer);
            groupBoxAnswer.Controls.Add(labelFour);
            groupBoxAnswer.Controls.Add(labelThree);
            groupBoxAnswer.Controls.Add(labelTwo);
            groupBoxAnswer.Controls.Add(labelOne);
            groupBoxAnswer.Controls.Add(textBoxAnswer4);
            groupBoxAnswer.Controls.Add(textBoxAnswer3);
            groupBoxAnswer.Controls.Add(textBoxAnswer2);
            groupBoxAnswer.Controls.Add(textBoxAnswer1);
            groupBoxAnswer.Controls.Add(groupBoxAnswerType);
            groupBoxAnswer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxAnswer.Location = new Point(20, 267);
            groupBoxAnswer.Name = "groupBoxAnswer";
            groupBoxAnswer.Size = new Size(1193, 468);
            groupBoxAnswer.TabIndex = 1;
            groupBoxAnswer.TabStop = false;
            groupBoxAnswer.Text = "Answers";
            // 
            // textBoxMarks
            // 
            textBoxMarks.Location = new Point(506, 55);
            textBoxMarks.MaxLength = 2;
            textBoxMarks.Name = "textBoxMarks";
            textBoxMarks.Size = new Size(113, 34);
            textBoxMarks.TabIndex = 15;
            textBoxMarks.Text = "1";
            textBoxMarks.TextAlign = HorizontalAlignment.Right;
            textBoxMarks.KeyPress += textBoxMarks_KeyPress;
            // 
            // labelMarks
            // 
            labelMarks.AutoSize = true;
            labelMarks.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarks.Location = new Point(506, 24);
            labelMarks.Name = "labelMarks";
            labelMarks.Size = new Size(72, 28);
            labelMarks.TabIndex = 14;
            labelMarks.Text = "Marks:";
            // 
            // checkBoxAnswer4
            // 
            checkBoxAnswer4.AutoSize = true;
            checkBoxAnswer4.Location = new Point(1129, 398);
            checkBoxAnswer4.Name = "checkBoxAnswer4";
            checkBoxAnswer4.Size = new Size(22, 21);
            checkBoxAnswer4.TabIndex = 13;
            checkBoxAnswer4.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer3
            // 
            checkBoxAnswer3.AutoSize = true;
            checkBoxAnswer3.Location = new Point(1129, 314);
            checkBoxAnswer3.Name = "checkBoxAnswer3";
            checkBoxAnswer3.Size = new Size(22, 21);
            checkBoxAnswer3.TabIndex = 12;
            checkBoxAnswer3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer2
            // 
            checkBoxAnswer2.AutoSize = true;
            checkBoxAnswer2.Location = new Point(1129, 235);
            checkBoxAnswer2.Name = "checkBoxAnswer2";
            checkBoxAnswer2.Size = new Size(22, 21);
            checkBoxAnswer2.TabIndex = 11;
            checkBoxAnswer2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer1
            // 
            checkBoxAnswer1.AutoSize = true;
            checkBoxAnswer1.Location = new Point(1129, 152);
            checkBoxAnswer1.Name = "checkBoxAnswer1";
            checkBoxAnswer1.Size = new Size(22, 21);
            checkBoxAnswer1.TabIndex = 10;
            checkBoxAnswer1.UseVisualStyleBackColor = true;
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.AutoSize = true;
            labelCorrectAnswer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorrectAnswer.Location = new Point(1104, 65);
            labelCorrectAnswer.MaximumSize = new Size(80, 0);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(79, 56);
            labelCorrectAnswer.TabIndex = 9;
            labelCorrectAnswer.Text = "Correct Answer";
            // 
            // labelFour
            // 
            labelFour.AutoSize = true;
            labelFour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFour.Location = new Point(6, 374);
            labelFour.Name = "labelFour";
            labelFour.Size = new Size(29, 28);
            labelFour.TabIndex = 8;
            labelFour.Text = "4.";
            // 
            // labelThree
            // 
            labelThree.AutoSize = true;
            labelThree.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelThree.Location = new Point(6, 290);
            labelThree.Name = "labelThree";
            labelThree.Size = new Size(28, 28);
            labelThree.TabIndex = 7;
            labelThree.Text = "3.";
            // 
            // labelTwo
            // 
            labelTwo.AutoSize = true;
            labelTwo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTwo.Location = new Point(6, 206);
            labelTwo.Name = "labelTwo";
            labelTwo.Size = new Size(28, 28);
            labelTwo.TabIndex = 6;
            labelTwo.Text = "2.";
            // 
            // labelOne
            // 
            labelOne.AutoSize = true;
            labelOne.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelOne.Location = new Point(9, 122);
            labelOne.Name = "labelOne";
            labelOne.Size = new Size(25, 28);
            labelOne.TabIndex = 5;
            labelOne.Text = "1.";
            // 
            // textBoxAnswer4
            // 
            textBoxAnswer4.Location = new Point(41, 374);
            textBoxAnswer4.MaxLength = 2000;
            textBoxAnswer4.Multiline = true;
            textBoxAnswer4.Name = "textBoxAnswer4";
            textBoxAnswer4.ScrollBars = ScrollBars.Vertical;
            textBoxAnswer4.Size = new Size(1053, 78);
            textBoxAnswer4.TabIndex = 4;
            // 
            // textBoxAnswer3
            // 
            textBoxAnswer3.Location = new Point(41, 290);
            textBoxAnswer3.MaxLength = 2000;
            textBoxAnswer3.Multiline = true;
            textBoxAnswer3.Name = "textBoxAnswer3";
            textBoxAnswer3.ScrollBars = ScrollBars.Vertical;
            textBoxAnswer3.Size = new Size(1053, 78);
            textBoxAnswer3.TabIndex = 3;
            // 
            // textBoxAnswer2
            // 
            textBoxAnswer2.Location = new Point(41, 206);
            textBoxAnswer2.MaxLength = 2000;
            textBoxAnswer2.Multiline = true;
            textBoxAnswer2.Name = "textBoxAnswer2";
            textBoxAnswer2.ScrollBars = ScrollBars.Vertical;
            textBoxAnswer2.Size = new Size(1053, 78);
            textBoxAnswer2.TabIndex = 2;
            // 
            // textBoxAnswer1
            // 
            textBoxAnswer1.Location = new Point(41, 122);
            textBoxAnswer1.MaxLength = 2000;
            textBoxAnswer1.Multiline = true;
            textBoxAnswer1.Name = "textBoxAnswer1";
            textBoxAnswer1.ScrollBars = ScrollBars.Vertical;
            textBoxAnswer1.Size = new Size(1053, 78);
            textBoxAnswer1.TabIndex = 1;
            // 
            // groupBoxAnswerType
            // 
            groupBoxAnswerType.Controls.Add(radioButtonMultiChoice);
            groupBoxAnswerType.Controls.Add(radioButtonSingleChoice);
            groupBoxAnswerType.Location = new Point(16, 24);
            groupBoxAnswerType.Name = "groupBoxAnswerType";
            groupBoxAnswerType.Size = new Size(362, 65);
            groupBoxAnswerType.TabIndex = 0;
            groupBoxAnswerType.TabStop = false;
            groupBoxAnswerType.Text = "Answer Type";
            // 
            // radioButtonMultiChoice
            // 
            radioButtonMultiChoice.AutoSize = true;
            radioButtonMultiChoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonMultiChoice.Location = new Point(190, 25);
            radioButtonMultiChoice.Name = "radioButtonMultiChoice";
            radioButtonMultiChoice.Size = new Size(188, 32);
            radioButtonMultiChoice.TabIndex = 1;
            radioButtonMultiChoice.Text = "Multiple Choices";
            radioButtonMultiChoice.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleChoice
            // 
            radioButtonSingleChoice.AutoSize = true;
            radioButtonSingleChoice.Checked = true;
            radioButtonSingleChoice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonSingleChoice.Location = new Point(12, 25);
            radioButtonSingleChoice.Name = "radioButtonSingleChoice";
            radioButtonSingleChoice.Size = new Size(160, 32);
            radioButtonSingleChoice.TabIndex = 0;
            radioButtonSingleChoice.TabStop = true;
            radioButtonSingleChoice.Text = "Single Choice";
            radioButtonSingleChoice.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(1155, 750);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(55, 58);
            buttonDelete.TabIndex = 24;
            toolTipButton.SetToolTip(buttonDelete, "Delete");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(1053, 750);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(55, 58);
            buttonCancel.TabIndex = 23;
            toolTipButton.SetToolTip(buttonCancel, "Close");
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(979, 750);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 22;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 819);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(1225, 35);
            statusStripMsg.TabIndex = 25;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 854);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxAnswer);
            Controls.Add(groupBoxQuestion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "QuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Details";
            groupBoxQuestion.ResumeLayout(false);
            groupBoxQuestion.PerformLayout();
            groupBoxAnswer.ResumeLayout(false);
            groupBoxAnswer.PerformLayout();
            groupBoxAnswerType.ResumeLayout(false);
            groupBoxAnswerType.PerformLayout();
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxQuestion;
        private TextBox textBoxQuestion;
        private GroupBox groupBoxAnswer;
        private Label labelFour;
        private Label labelThree;
        private Label labelTwo;
        private Label labelOne;
        private TextBox textBoxAnswer4;
        private TextBox textBoxAnswer3;
        private TextBox textBoxAnswer2;
        private TextBox textBoxAnswer1;
        private GroupBox groupBoxAnswerType;
        private RadioButton radioButtonMultiChoice;
        private RadioButton radioButtonSingleChoice;
        private Button buttonDelete;
        private Button buttonCancel;
        private Button buttonSave;
        private ToolTip toolTipButton;
        private CheckBox checkBoxAnswer4;
        private CheckBox checkBoxAnswer3;
        private CheckBox checkBoxAnswer2;
        private CheckBox checkBoxAnswer1;
        private Label labelCorrectAnswer;
        private ToolTip toolTip1;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private TextBox textBoxMarks;
        private Label labelMarks;
    }
}