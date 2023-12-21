namespace ExamMaster
{
    partial class PrivilegeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegeForm));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "ManageUser:Admin" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "ManageUser:Readonly" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point));
            buttonClose = new Button();
            groupBoxPrivilegeData = new GroupBox();
            hlabelId = new Label();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonSave = new Button();
            textBoxPrivilege = new TextBox();
            labelPrivilege = new Label();
            groupBoxPrivileges = new GroupBox();
            listViewPrivileges = new ListView();
            columnHeaderPrivilege = new ColumnHeader();
            toolTipButton = new ToolTip(components);
            statusStripMsg = new StatusStrip();
            toolStripStatusLabelMsg = new ToolStripStatusLabel();
            groupBoxPrivilegeData.SuspendLayout();
            groupBoxPrivileges.SuspendLayout();
            statusStripMsg.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(913, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(55, 58);
            buttonClose.TabIndex = 15;
            toolTipButton.SetToolTip(buttonClose, "Close");
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupBoxPrivilegeData
            // 
            groupBoxPrivilegeData.Controls.Add(hlabelId);
            groupBoxPrivilegeData.Controls.Add(buttonDelete);
            groupBoxPrivilegeData.Controls.Add(buttonClear);
            groupBoxPrivilegeData.Controls.Add(buttonSave);
            groupBoxPrivilegeData.Controls.Add(textBoxPrivilege);
            groupBoxPrivilegeData.Controls.Add(labelPrivilege);
            groupBoxPrivilegeData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPrivilegeData.Location = new Point(411, 65);
            groupBoxPrivilegeData.Name = "groupBoxPrivilegeData";
            groupBoxPrivilegeData.Size = new Size(546, 223);
            groupBoxPrivilegeData.TabIndex = 14;
            groupBoxPrivilegeData.TabStop = false;
            groupBoxPrivilegeData.Text = "Privilege Info";
            // 
            // hlabelId
            // 
            hlabelId.AutoSize = true;
            hlabelId.Location = new Point(27, 183);
            hlabelId.Name = "hlabelId";
            hlabelId.Size = new Size(82, 28);
            hlabelId.TabIndex = 11;
            hlabelId.Text = "hlabelId";
            hlabelId.Visible = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(449, 153);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(55, 58);
            buttonDelete.TabIndex = 10;
            toolTipButton.SetToolTip(buttonDelete, "Delete");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(347, 153);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(55, 58);
            buttonClear.TabIndex = 9;
            toolTipButton.SetToolTip(buttonClear, "Clear");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(273, 153);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(55, 58);
            buttonSave.TabIndex = 8;
            toolTipButton.SetToolTip(buttonSave, "Save");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxPrivilege
            // 
            textBoxPrivilege.Location = new Point(27, 78);
            textBoxPrivilege.MaxLength = 40;
            textBoxPrivilege.Name = "textBoxPrivilege";
            textBoxPrivilege.Size = new Size(477, 34);
            textBoxPrivilege.TabIndex = 1;
            // 
            // labelPrivilege
            // 
            labelPrivilege.AutoSize = true;
            labelPrivilege.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrivilege.Location = new Point(27, 50);
            labelPrivilege.Name = "labelPrivilege";
            labelPrivilege.Size = new Size(95, 28);
            labelPrivilege.TabIndex = 0;
            labelPrivilege.Text = "Privilege:";
            // 
            // groupBoxPrivileges
            // 
            groupBoxPrivileges.Controls.Add(listViewPrivileges);
            groupBoxPrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxPrivileges.Location = new Point(20, 65);
            groupBoxPrivileges.Name = "groupBoxPrivileges";
            groupBoxPrivileges.Size = new Size(371, 391);
            groupBoxPrivileges.TabIndex = 13;
            groupBoxPrivileges.TabStop = false;
            groupBoxPrivileges.Text = "Privileges";
            // 
            // listViewPrivileges
            // 
            listViewPrivileges.Columns.AddRange(new ColumnHeader[] { columnHeaderPrivilege });
            listViewPrivileges.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listViewPrivileges.FullRowSelect = true;
            listViewPrivileges.GridLines = true;
            listViewPrivileges.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listViewPrivileges.Location = new Point(11, 38);
            listViewPrivileges.Name = "listViewPrivileges";
            listViewPrivileges.Size = new Size(354, 343);
            listViewPrivileges.TabIndex = 0;
            listViewPrivileges.UseCompatibleStateImageBehavior = false;
            listViewPrivileges.View = View.Details;
            listViewPrivileges.Click += listViewPrivilege_Click;
            // 
            // columnHeaderPrivilege
            // 
            columnHeaderPrivilege.Text = "Privilege";
            columnHeaderPrivilege.Width = 320;
            // 
            // statusStripMsg
            // 
            statusStripMsg.BackColor = SystemColors.Control;
            statusStripMsg.ImageScalingSize = new Size(24, 24);
            statusStripMsg.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMsg });
            statusStripMsg.Location = new Point(0, 476);
            statusStripMsg.Name = "statusStripMsg";
            statusStripMsg.Size = new Size(968, 35);
            statusStripMsg.TabIndex = 16;
            // 
            // toolStripStatusLabelMsg
            // 
            toolStripStatusLabelMsg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabelMsg.Name = "toolStripStatusLabelMsg";
            toolStripStatusLabelMsg.Size = new Size(226, 28);
            toolStripStatusLabelMsg.Text = "toolStripStatusLabelMsg";
            // 
            // PrivilegeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 511);
            ControlBox = false;
            Controls.Add(statusStripMsg);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxPrivilegeData);
            Controls.Add(groupBoxPrivileges);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PrivilegeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Privilege Management";
            groupBoxPrivilegeData.ResumeLayout(false);
            groupBoxPrivilegeData.PerformLayout();
            groupBoxPrivileges.ResumeLayout(false);
            statusStripMsg.ResumeLayout(false);
            statusStripMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private GroupBox groupBoxPrivilegeData;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonSave;
        private TextBox textBoxPrivilege;
        private Label labelPrivilege;
        private GroupBox groupBoxPrivileges;
        private ListView listViewPrivileges;
        private ColumnHeader columnHeaderPrivilege;
        private ToolTip toolTipButton;
        private Label hlabelId;
        private StatusStrip statusStripMsg;
        private ToolStripStatusLabel toolStripStatusLabelMsg;
    }
}