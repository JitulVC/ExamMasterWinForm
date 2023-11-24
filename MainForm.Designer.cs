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
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrivilege = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRolePrivilege = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelErrMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMsgText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.GripMargin = new System.Windows.Forms.Padding(8);
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExam,
            this.toolStripSeparator1,
            this.toolStripButtonStudent,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButtonUser,
            this.toolStripSeparator4,
            this.toolStripButtonRole,
            this.toolStripSeparator5,
            this.toolStripButtonPrivilege,
            this.toolStripSeparator6,
            this.toolStripButtonRolePrivilege});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Margin = new System.Windows.Forms.Padding(8);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toolStripMain.Size = new System.Drawing.Size(1578, 74);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // toolStripButtonExam
            // 
            this.toolStripButtonExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExam.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExam.Image")));
            this.toolStripButtonExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExam.Name = "toolStripButtonExam";
            this.toolStripButtonExam.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonExam.Text = "Exam Management";
            this.toolStripButtonExam.Click += new System.EventHandler(this.toolStripButtonExam_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButtonStudent
            // 
            this.toolStripButtonStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStudent.Image")));
            this.toolStripButtonStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStudent.Name = "toolStripButtonStudent";
            this.toolStripButtonStudent.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonStudent.Text = "Student Management";
            this.toolStripButtonStudent.Click += new System.EventHandler(this.toolStripButtonStudent_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButtonUser
            // 
            this.toolStripButtonUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUser.Image")));
            this.toolStripButtonUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUser.Name = "toolStripButtonUser";
            this.toolStripButtonUser.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonUser.Text = "User Management";
            this.toolStripButtonUser.Click += new System.EventHandler(this.toolStripButtonUser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButtonRole
            // 
            this.toolStripButtonRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRole.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRole.Image")));
            this.toolStripButtonRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRole.Name = "toolStripButtonRole";
            this.toolStripButtonRole.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonRole.Text = "Role Management";
            this.toolStripButtonRole.Click += new System.EventHandler(this.toolStripButtonRole_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButtonPrivilege
            // 
            this.toolStripButtonPrivilege.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrivilege.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrivilege.Image")));
            this.toolStripButtonPrivilege.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrivilege.Name = "toolStripButtonPrivilege";
            this.toolStripButtonPrivilege.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonPrivilege.Text = "Privilege Management";
            this.toolStripButtonPrivilege.Click += new System.EventHandler(this.toolStripButtonPrivilege_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButtonRolePrivilege
            // 
            this.toolStripButtonRolePrivilege.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRolePrivilege.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRolePrivilege.Image")));
            this.toolStripButtonRolePrivilege.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRolePrivilege.Name = "toolStripButtonRolePrivilege";
            this.toolStripButtonRolePrivilege.Size = new System.Drawing.Size(52, 53);
            this.toolStripButtonRolePrivilege.Text = "Role Privileges";
            this.toolStripButtonRolePrivilege.Click += new System.EventHandler(this.toolStripButtonRolePrivilege_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMsg,
            this.toolStripStatusLabelErrMsg,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelMsgText,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStripMain.Location = new System.Drawing.Point(0, 862);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1578, 32);
            this.statusStripMain.TabIndex = 5;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMsg
            // 
            this.toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            this.toolStripStatusLabelMsg.Size = new System.Drawing.Size(86, 25);
            this.toolStripStatusLabelMsg.Text = "Message:";
            // 
            // toolStripStatusLabelErrMsg
            // 
            this.toolStripStatusLabelErrMsg.Name = "toolStripStatusLabelErrMsg";
            this.toolStripStatusLabelErrMsg.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 25);
            this.toolStripStatusLabel1.ToolTipText = "xxxxxxxxxxxxxxxxxxxxx                                     ";
            // 
            // toolStripStatusLabelMsgText
            // 
            this.toolStripStatusLabelMsgText.Name = "toolStripStatusLabelMsgText";
            this.toolStripStatusLabelMsgText.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(183, 25);
            this.toolStripStatusLabel3.Text = ". . . . . . . . . . . . . . . . . . . ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(194, 25);
            this.toolStripStatusLabel2.Text = "(c) 2023 JRC CloudTech";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1578, 894);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Master";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}