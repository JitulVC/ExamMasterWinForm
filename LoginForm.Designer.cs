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
            groupBoxLogin = new GroupBox();
            labelMsg = new Label();
            buttonCencel = new Button();
            buttonLogin = new Button();
            textBoxPasscode = new TextBox();
            labelPasscode = new Label();
            textBoxUserAccount = new TextBox();
            labelUserAccount = new Label();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(labelMsg);
            groupBoxLogin.Controls.Add(buttonCencel);
            groupBoxLogin.Controls.Add(buttonLogin);
            groupBoxLogin.Controls.Add(textBoxPasscode);
            groupBoxLogin.Controls.Add(labelPasscode);
            groupBoxLogin.Controls.Add(textBoxUserAccount);
            groupBoxLogin.Controls.Add(labelUserAccount);
            groupBoxLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLogin.Location = new Point(61, 41);
            groupBoxLogin.Margin = new Padding(4);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(4);
            groupBoxLogin.Size = new Size(644, 317);
            groupBoxLogin.TabIndex = 0;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "User Credentials";
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.ForeColor = Color.OrangeRed;
            labelMsg.Location = new Point(32, 283);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(0, 28);
            labelMsg.TabIndex = 6;
            // 
            // buttonCencel
            // 
            buttonCencel.Image = (Image)resources.GetObject("buttonCencel.Image");
            buttonCencel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCencel.Location = new Point(458, 191);
            buttonCencel.Name = "buttonCencel";
            buttonCencel.Size = new Size(148, 72);
            buttonCencel.TabIndex = 5;
            buttonCencel.Text = "Cancel";
            buttonCencel.TextAlign = ContentAlignment.MiddleRight;
            buttonCencel.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonCencel.UseVisualStyleBackColor = true;
            buttonCencel.Click += buttonCencel_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Image = (Image)resources.GetObject("buttonLogin.Image");
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(288, 191);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(141, 72);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPasscode
            // 
            textBoxPasscode.Location = new Point(221, 97);
            textBoxPasscode.Name = "textBoxPasscode";
            textBoxPasscode.PasswordChar = '*';
            textBoxPasscode.Size = new Size(330, 34);
            textBoxPasscode.TabIndex = 3;
            textBoxPasscode.Enter += textBoxPasscode_Enter;
            // 
            // labelPasscode
            // 
            labelPasscode.AutoSize = true;
            labelPasscode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPasscode.Location = new Point(32, 105);
            labelPasscode.Name = "labelPasscode";
            labelPasscode.Size = new Size(100, 28);
            labelPasscode.TabIndex = 2;
            labelPasscode.Text = "Passcode:";
            // 
            // textBoxUserAccount
            // 
            textBoxUserAccount.Location = new Point(221, 48);
            textBoxUserAccount.Margin = new Padding(4);
            textBoxUserAccount.Name = "textBoxUserAccount";
            textBoxUserAccount.Size = new Size(330, 34);
            textBoxUserAccount.TabIndex = 1;
            textBoxUserAccount.Enter += textBoxUserAccount_Enter;
            // 
            // labelUserAccount
            // 
            labelUserAccount.AutoSize = true;
            labelUserAccount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserAccount.Location = new Point(32, 52);
            labelUserAccount.Margin = new Padding(4, 0, 4, 0);
            labelUserAccount.Name = "labelUserAccount";
            labelUserAccount.Size = new Size(138, 28);
            labelUserAccount.TabIndex = 0;
            labelUserAccount.Text = "User Account:";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(765, 371);
            ControlBox = false;
            Controls.Add(groupBoxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            Shown += LoginForm_Shown;
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
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