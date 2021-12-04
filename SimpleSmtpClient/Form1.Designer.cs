namespace SimpleSmtpClient
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guiUseSsl = new System.Windows.Forms.CheckBox();
            this.guiPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.guiUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guiUseCredentials = new System.Windows.Forms.CheckBox();
            this.guiPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.guiServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.emailGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guiFromName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.htmlEditControl1 = new Zoople.HTMLEditControl();
            this.guiSendMail = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.guiEmailSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.guiEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.guiEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IPCLI = new System.Windows.Forms.Label();
            this.serverGroup.SuspendLayout();
            this.emailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.comboBox1);
            this.serverGroup.Controls.Add(this.guiUseSsl);
            this.serverGroup.Controls.Add(this.guiPassword);
            this.serverGroup.Controls.Add(this.lblPassword);
            this.serverGroup.Controls.Add(this.guiUser);
            this.serverGroup.Controls.Add(this.lblUserName);
            this.serverGroup.Controls.Add(this.guiUseCredentials);
            this.serverGroup.Controls.Add(this.guiPort);
            this.serverGroup.Controls.Add(this.lblPort);
            this.serverGroup.Controls.Add(this.guiServerName);
            this.serverGroup.Controls.Add(this.lblServerName);
            this.serverGroup.Location = new System.Drawing.Point(12, 19);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(540, 133);
            this.serverGroup.TabIndex = 0;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "SMTP Configuration";
            this.serverGroup.Enter += new System.EventHandler(this.serverGroup_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Checked = true;
            this.guiUseSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guiUseSsl.Location = new System.Drawing.Point(25, 97);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(68, 17);
            this.guiUseSsl.TabIndex = 9;
            this.guiUseSsl.Text = "Use SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(434, 66);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.Size = new System.Drawing.Size(87, 20);
            this.guiPassword.TabIndex = 8;
            this.guiPassword.Text = "TTrr1990??";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(378, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(217, 66);
            this.guiUser.Name = "guiUser";
            this.guiUser.Size = new System.Drawing.Size(154, 20);
            this.guiUser.TabIndex = 6;
            this.guiUser.Text = "photan@trabando2020.onmicrosoft.com";
            this.guiUser.TextChanged += new System.EventHandler(this.guiUser_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(152, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "SMTP User";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Checked = true;
            this.guiUseCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guiUseCredentials.Location = new System.Drawing.Point(25, 69);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(116, 17);
            this.guiUseCredentials.TabIndex = 4;
            this.guiUseCredentials.Text = "Use Authentication";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(449, 28);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(73, 20);
            this.guiPort.TabIndex = 3;
            this.guiPort.Text = "587";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(419, 31);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(96, 28);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(289, 20);
            this.guiServerName.TabIndex = 1;
            this.guiServerName.Text = "smtp.office365.com";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 31);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(71, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "SMTP Server";
            // 
            // emailGroup
            // 
            this.emailGroup.Controls.Add(this.label2);
            this.emailGroup.Controls.Add(this.label1);
            this.emailGroup.Controls.Add(this.textBox1);
            this.emailGroup.Controls.Add(this.guiFromName);
            this.emailGroup.Controls.Add(this.button1);
            this.emailGroup.Controls.Add(this.htmlEditControl1);
            this.emailGroup.Controls.Add(this.guiSendMail);
            this.emailGroup.Controls.Add(this.lblBody);
            this.emailGroup.Controls.Add(this.guiEmailSubject);
            this.emailGroup.Controls.Add(this.lblSubject);
            this.emailGroup.Controls.Add(this.guiEmailTo);
            this.emailGroup.Controls.Add(this.lblEmailTo);
            this.emailGroup.Controls.Add(this.guiEmailFrom);
            this.emailGroup.Controls.Add(this.lblEmailFrom);
            this.emailGroup.Location = new System.Drawing.Point(12, 202);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Size = new System.Drawing.Size(1246, 562);
            this.emailGroup.TabIndex = 1;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "Email Message";
            this.emailGroup.Enter += new System.EventHandler(this.emailGroup_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "From name";
            // 
            // guiFromName
            // 
            this.guiFromName.Location = new System.Drawing.Point(76, 56);
            this.guiFromName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guiFromName.Name = "guiFromName";
            this.guiFromName.Size = new System.Drawing.Size(445, 20);
            this.guiFromName.TabIndex = 13;
            this.guiFromName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // htmlEditControl1
            // 
            this.htmlEditControl1.AcceptsReturn = true;
            this.htmlEditControl1.AllowDragInternal = true;
            this.htmlEditControl1.BaseURL = null;
            this.htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            this.htmlEditControl1.CodeEditor.Enabled = true;
            this.htmlEditControl1.CodeEditor.Locked = false;
            this.htmlEditControl1.CodeEditor.WordWrap = false;
            this.htmlEditControl1.CSSText = null;
            this.htmlEditControl1.DocumentHTML = null;
            this.htmlEditControl1.EditingDisabled = false;
            this.htmlEditControl1.EnableInlineSpelling = false;
            this.htmlEditControl1.FontsList = null;
            this.htmlEditControl1.HiddenButtons = null;
            this.htmlEditControl1.ImageStorageLocation = null;
            this.htmlEditControl1.InCodeView = false;
            this.htmlEditControl1.LanguageFile = null;
            this.htmlEditControl1.LicenceActivationKey = null;
            this.htmlEditControl1.LicenceKey = null;
            this.htmlEditControl1.LicenceKeyInlineSpelling = null;
            this.htmlEditControl1.Location = new System.Drawing.Point(65, 164);
            this.htmlEditControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.htmlEditControl1.Name = "htmlEditControl1";
            this.htmlEditControl1.Size = new System.Drawing.Size(531, 371);
            this.htmlEditControl1.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("htmlEditControl1.SpellingAutoCorrectionList")));
            this.htmlEditControl1.TabIndex = 11;
            this.htmlEditControl1.ToolstripImageScalingSize = new System.Drawing.Size(24, 24);
            this.htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(893, 61);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(130, 44);
            this.guiSendMail.TabIndex = 2;
            this.guiSendMail.Text = "Send Mail";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(22, 143);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(76, 112);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(446, 20);
            this.guiEmailSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(22, 116);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(75, 89);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(446, 20);
            this.guiEmailTo.TabIndex = 4;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(21, 92);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(20, 13);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "To";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Enabled = false;
            this.guiEmailFrom.Location = new System.Drawing.Point(76, 28);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.ReadOnly = true;
            this.guiEmailFrom.Size = new System.Drawing.Size(446, 20);
            this.guiEmailFrom.TabIndex = 2;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(22, 30);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(30, 13);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mailist Max 499";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 467);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // IPCLI
            // 
            this.IPCLI.AutoSize = true;
            this.IPCLI.Location = new System.Drawing.Point(623, 34);
            this.IPCLI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IPCLI.Name = "IPCLI";
            this.IPCLI.Size = new System.Drawing.Size(60, 13);
            this.IPCLI.TabIndex = 15;
            this.IPCLI.Text = "Ip Address ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 776);
            this.Controls.Add(this.IPCLI);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Simple SMTP Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.emailGroup.ResumeLayout(false);
            this.emailGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.TextBox guiPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox guiUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox guiUseCredentials;
        private System.Windows.Forms.TextBox guiPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox guiServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.GroupBox emailGroup;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox guiEmailSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox guiEmailTo;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox guiEmailFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.Button guiSendMail;
        private System.Windows.Forms.CheckBox guiUseSsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Zoople.HTMLEditControl htmlEditControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox guiFromName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IPCLI;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

