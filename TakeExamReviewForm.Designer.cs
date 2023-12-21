namespace ExamMaster
{
    partial class TakeExamReviewForm
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "1.", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "What is the best way to protect S3 bucket from public access?", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Submitted", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "2.", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Review the following Security Group settings and advise which setting will allow My SQL access within the VPC network?", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Skipped", SystemColors.WindowText, SystemColors.Window, new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeExamReviewForm));
            groupBoxQuesions = new GroupBox();
            labelHint = new Label();
            listViewQuestions = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            toolTipButton = new ToolTip(components);
            buttonReviewSkipped = new Button();
            buttonClose = new Button();
            buttonReviewAll = new Button();
            buttonReviewMarked = new Button();
            groupBoxQuesions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxQuesions
            // 
            groupBoxQuesions.Controls.Add(labelHint);
            groupBoxQuesions.Controls.Add(listViewQuestions);
            groupBoxQuesions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxQuesions.Location = new Point(13, 43);
            groupBoxQuesions.Margin = new Padding(4, 5, 4, 5);
            groupBoxQuesions.Name = "groupBoxQuesions";
            groupBoxQuesions.Padding = new Padding(4, 5, 4, 5);
            groupBoxQuesions.Size = new Size(926, 619);
            groupBoxQuesions.TabIndex = 13;
            groupBoxQuesions.TabStop = false;
            groupBoxQuesions.Text = "Questions";
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelHint.Location = new Point(11, 576);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(269, 25);
            labelHint.TabIndex = 23;
            labelHint.Text = "Double click to Review Question";
            // 
            // listViewQuestions
            // 
            listViewQuestions.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewQuestions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listViewQuestions.FullRowSelect = true;
            listViewQuestions.GridLines = true;
            listViewQuestions.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewQuestions.Location = new Point(11, 34);
            listViewQuestions.Margin = new Padding(4, 5, 4, 5);
            listViewQuestions.Name = "listViewQuestions";
            listViewQuestions.Size = new Size(907, 537);
            listViewQuestions.TabIndex = 0;
            listViewQuestions.UseCompatibleStateImageBehavior = false;
            listViewQuestions.View = View.Details;
            listViewQuestions.DoubleClick += listViewQuestions_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Q.No.";
            columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Questions";
            columnHeader2.Width = 680;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 115;
            // 
            // buttonReviewSkipped
            // 
            buttonReviewSkipped.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReviewSkipped.Location = new Point(595, 687);
            buttonReviewSkipped.Name = "buttonReviewSkipped";
            buttonReviewSkipped.Size = new Size(163, 45);
            buttonReviewSkipped.TabIndex = 16;
            buttonReviewSkipped.Text = "Review Skipped";
            buttonReviewSkipped.UseVisualStyleBackColor = true;
            buttonReviewSkipped.Click += buttonReviewSkipped_Click;
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(899, -6);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 17;
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonReviewAll
            // 
            buttonReviewAll.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReviewAll.Location = new Point(415, 687);
            buttonReviewAll.Name = "buttonReviewAll";
            buttonReviewAll.Size = new Size(163, 45);
            buttonReviewAll.TabIndex = 18;
            buttonReviewAll.Text = "Review All";
            buttonReviewAll.UseVisualStyleBackColor = true;
            buttonReviewAll.Click += buttonReviewAll_Click;
            // 
            // buttonReviewMarked
            // 
            buttonReviewMarked.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReviewMarked.Location = new Point(776, 687);
            buttonReviewMarked.Name = "buttonReviewMarked";
            buttonReviewMarked.Size = new Size(163, 45);
            buttonReviewMarked.TabIndex = 19;
            buttonReviewMarked.Text = "Review Marked";
            buttonReviewMarked.UseVisualStyleBackColor = true;
            buttonReviewMarked.Click += buttonReviewMarked_Click;
            // 
            // TakeExamReviewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 744);
            ControlBox = false;
            Controls.Add(buttonReviewMarked);
            Controls.Add(buttonReviewAll);
            Controls.Add(buttonClose);
            Controls.Add(buttonReviewSkipped);
            Controls.Add(groupBoxQuesions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TakeExamReviewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Review Quesions";
            groupBoxQuesions.ResumeLayout(false);
            groupBoxQuesions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxQuesions;
        private ListView listViewQuestions;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolTip toolTipButton;
        private Label labelHint;
        private Button buttonReviewSkipped;
        private Button buttonClose;
        private Button buttonReviewAll;
        private Button buttonReviewMarked;
    }
}