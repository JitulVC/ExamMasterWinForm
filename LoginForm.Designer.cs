namespace ExamMaster
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labelMsg = new System.Windows.Forms.Label();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasscode = new System.Windows.Forms.TextBox();
            this.labelPasscode = new System.Windows.Forms.Label();
            this.textBoxUserAccount = new System.Windows.Forms.TextBox();
            this.labelUserAccount = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelMsg);
            this.groupBoxLogin.Controls.Add(this.buttonCencel);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxPasscode);
            this.groupBoxLogin.Controls.Add(this.labelPasscode);
            this.groupBoxLogin.Controls.Add(this.textBoxUserAccount);
            this.groupBoxLogin.Controls.Add(this.labelUserAccount);
            this.groupBoxLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLogin.Location = new System.Drawing.Point(61, 41);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(644, 317);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "User Credentials";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelMsg.Location = new System.Drawing.Point(32, 283);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 28);
            this.labelMsg.TabIndex = 6;
            // 
            // buttonCencel
            // 
            this.buttonCencel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCencel.Image")));
            this.buttonCencel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCencel.Location = new System.Drawing.Point(458, 191);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(148, 72);
            this.buttonCencel.TabIndex = 5;
            this.buttonCencel.Text = "Cancel";
            this.buttonCencel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCencel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCencel.UseVisualStyleBackColor = true;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(288, 191);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(141, 72);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasscode
            // 
            this.textBoxPasscode.Location = new System.Drawing.Point(221, 97);
            this.textBoxPasscode.Name = "textBoxPasscode";
            this.textBoxPasscode.PasswordChar = '*';
            this.textBoxPasscode.Size = new System.Drawing.Size(330, 34);
            this.textBoxPasscode.TabIndex = 3;
            this.textBoxPasscode.Enter += new System.EventHandler(this.textBoxPasscode_Enter);
            // 
            // labelPasscode
            // 
            this.labelPasscode.AutoSize = true;
            this.labelPasscode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasscode.Location = new System.Drawing.Point(32, 105);
            this.labelPasscode.Name = "labelPasscode";
            this.labelPasscode.Size = new System.Drawing.Size(95, 28);
            this.labelPasscode.TabIndex = 2;
            this.labelPasscode.Text = "Passcode:";
            // 
            // textBoxUserAccount
            // 
            this.textBoxUserAccount.Location = new System.Drawing.Point(221, 48);
            this.textBoxUserAccount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserAccount.Name = "textBoxUserAccount";
            this.textBoxUserAccount.Size = new System.Drawing.Size(330, 34);
            this.textBoxUserAccount.TabIndex = 1;
            this.textBoxUserAccount.Enter += new System.EventHandler(this.textBoxUserAccount_Enter);
            // 
            // labelUserAccount
            // 
            this.labelUserAccount.AutoSize = true;
            this.labelUserAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserAccount.Location = new System.Drawing.Point(32, 52);
            this.labelUserAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserAccount.Name = "labelUserAccount";
            this.labelUserAccount.Size = new System.Drawing.Size(132, 28);
            this.labelUserAccount.TabIndex = 0;
            this.labelUserAccount.Text = "User Account:";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 371);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxLogin;
        private Button buttonCencel;
        private Button buttonLogin;
        private TextBox textBoxPasscode;
        private Label labelPasscode;
        private TextBox textBoxUserAccount;
        private Label labelUserAccount;
        private Label labelMsg;
    }
}