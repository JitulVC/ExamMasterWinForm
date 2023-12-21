namespace ExamMaster
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripMain = new ToolStrip();
            toolStripButtonExam = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonStudent = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonUser = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonRole = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonPrivilege = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButtonRolePrivilege = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            statusStripMain = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            toolStripStatusLabelErrMsg = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelMsgText = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMain
            // 
            toolStripMain.Dock = DockStyle.Bottom;
            toolStripMain.GripMargin = new Padding(8);
            toolStripMain.ImageScalingSize = new Size(48, 48);
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripButtonExam, toolStripSeparator1, toolStripButtonStudent, toolStripSeparator2, toolStripButton1, toolStripSeparator3, toolStripButtonUser, toolStripSeparator4, toolStripButtonRole, toolStripSeparator5, toolStripButtonPrivilege, toolStripSeparator6, toolStripButtonRolePrivilege, toolStripSeparator7 });
            toolStripMain.LayoutStyle = ToolStripLayoutStyle.Flow;
            toolStripMain.Location = new Point(0, 806);
            toolStripMain.Margin = new Padding(8);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Padding = new Padding(0, 12, 0, 12);
            toolStripMain.Size = new Size(1578, 88);
            toolStripMain.Stretch = true;
            toolStripMain.TabIndex = 3;
            toolStripMain.Text = "toolStripMain";
            // 
            // toolStripButtonExam
            // 
            toolStripButtonExam.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExam.Image = (Image)resources.GetObject("toolStripButtonExam.Image");
            toolStripButtonExam.ImageTransparentColor = Color.Magenta;
            toolStripButtonExam.Margin = new Padding(12, 0, 0, 12);
            toolStripButtonExam.Name = "toolStripButtonExam";
            toolStripButtonExam.Size = new Size(52, 52);
            toolStripButtonExam.Text = "Exam Management";
            toolStripButtonExam.Click += toolStripButtonExam_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 23);
            // 
            // toolStripButtonStudent
            // 
            toolStripButtonStudent.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStudent.Image = (Image)resources.GetObject("toolStripButtonStudent.Image");
            toolStripButtonStudent.ImageTransparentColor = Color.Magenta;
            toolStripButtonStudent.Margin = new Padding(12, 0, 12, 0);
            toolStripButtonStudent.Name = "toolStripButtonStudent";
            toolStripButtonStudent.Size = new Size(52, 52);
            toolStripButtonStudent.Text = "Student Management";
            toolStripButtonStudent.Click += toolStripButtonStudent_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 23);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(6, 23);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 23);
            // 
            // toolStripButtonUser
            // 
            toolStripButtonUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUser.Image = (Image)resources.GetObject("toolStripButtonUser.Image");
            toolStripButtonUser.ImageTransparentColor = Color.Magenta;
            toolStripButtonUser.Margin = new Padding(12, 0, 12, 0);
            toolStripButtonUser.Name = "toolStripButtonUser";
            toolStripButtonUser.Size = new Size(52, 52);
            toolStripButtonUser.Text = "User Management";
            toolStripButtonUser.Click += toolStripButtonUser_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 23);
            // 
            // toolStripButtonRole
            // 
            toolStripButtonRole.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRole.Image = (Image)resources.GetObject("toolStripButtonRole.Image");
            toolStripButtonRole.ImageTransparentColor = Color.Magenta;
            toolStripButtonRole.Margin = new Padding(12, 0, 12, 0);
            toolStripButtonRole.Name = "toolStripButtonRole";
            toolStripButtonRole.Size = new Size(52, 52);
            toolStripButtonRole.Text = "Role Management";
            toolStripButtonRole.Click += toolStripButtonRole_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 23);
            // 
            // toolStripButtonPrivilege
            // 
            toolStripButtonPrivilege.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrivilege.Image = (Image)resources.GetObject("toolStripButtonPrivilege.Image");
            toolStripButtonPrivilege.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrivilege.Margin = new Padding(12, 0, 12, 0);
            toolStripButtonPrivilege.Name = "toolStripButtonPrivilege";
            toolStripButtonPrivilege.Size = new Size(52, 52);
            toolStripButtonPrivilege.Text = "Privilege Management";
            toolStripButtonPrivilege.Click += toolStripButtonPrivilege_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 23);
            // 
            // toolStripButtonRolePrivilege
            // 
            toolStripButtonRolePrivilege.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRolePrivilege.Image = (Image)resources.GetObject("toolStripButtonRolePrivilege.Image");
            toolStripButtonRolePrivilege.ImageTransparentColor = Color.Magenta;
            toolStripButtonRolePrivilege.Margin = new Padding(12, 0, 12, 0);
            toolStripButtonRolePrivilege.Name = "toolStripButtonRolePrivilege";
            toolStripButtonRolePrivilege.Size = new Size(52, 52);
            toolStripButtonRolePrivilege.Text = "Role Privileges";
            toolStripButtonRolePrivilege.Click += toolStripButtonRolePrivilege_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 23);
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(24, 24);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg, toolStripStatusLabelErrMsg, toolStripStatusLabel1, toolStripStatusLabelMsgText, toolStripStatusLabel3, toolStripStatusLabel2 });
            statusStripMain.Location = new Point(0, 774);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1578, 32);
            statusStripMain.TabIndex = 5;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(86, 25);
            toolStripStatusLabelMsg.Text = "Message:";
            // 
            // toolStripStatusLabelErrMsg
            // 
            toolStripStatusLabelErrMsg.Name = "toolStripStatusLabelErrMsg";
            toolStripStatusLabelErrMsg.Size = new Size(0, 25);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 25);
            toolStripStatusLabel1.ToolTipText = "xxxxxxxxxxxxxxxxxxxxx                                     ";
            // 
            // toolStripStatusLabelMsgText
            // 
            toolStripStatusLabelMsgText.Name = "toolStripStatusLabelMsgText";
            toolStripStatusLabelMsgText.Size = new Size(0, 25);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(183, 25);
            toolStripStatusLabel3.Text = ". . . . . . . . . . . . . . . . . . . ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(194, 25);
            toolStripStatusLabel2.Text = "(c) 2023 JRC CloudTech";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1578, 894);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Master";
            Shown += MainForm_Shown;
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripButton toolStripButtonExam;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonStudent;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonUser;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButtonRole;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonPrivilege;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButtonRolePrivilege;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
        private ToolStripStatusLabel toolStripStatusLabelErrMsg;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelMsgText;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripSeparator toolStripSeparator7;
    }
}