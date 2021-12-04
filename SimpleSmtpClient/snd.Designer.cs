
namespace SimpleSmtpClient
{
    partial class snd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snd));
            this.label2 = new System.Windows.Forms.Label();
            this.htmlEditControl1 = new Zoople.HTMLEditControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailGroup = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guiSendMail = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.guiEmailSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.guiEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.guiEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.guiServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.guiUser = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guiUseCredentials = new System.Windows.Forms.CheckBox();
            this.guiPort = new System.Windows.Forms.TextBox();
            this.guiUseSsl = new System.Windows.Forms.CheckBox();
            this.guiPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.emailGroup.SuspendLayout();
            this.serverGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1007, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 13;
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
            this.htmlEditControl1.Location = new System.Drawing.Point(98, 253);
            this.htmlEditControl1.Name = "htmlEditControl1";
            this.htmlEditControl1.Size = new System.Drawing.Size(796, 379);
            this.htmlEditControl1.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("htmlEditControl1.SpellingAutoCorrectionList")));
            this.htmlEditControl1.TabIndex = 11;
            this.htmlEditControl1.ToolstripImageScalingSize = new System.Drawing.Size(24, 24);
            this.htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(928, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 387);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mailist";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(926, 278);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(246, 306);
            this.textBox2.TabIndex = 12;
            // 
            // emailGroup
            // 
            this.emailGroup.Controls.Add(this.checkBox1);
            this.emailGroup.Controls.Add(this.button1);
            this.emailGroup.Controls.Add(this.label2);
            this.emailGroup.Controls.Add(this.textBox2);
            this.emailGroup.Controls.Add(this.htmlEditControl1);
            this.emailGroup.Controls.Add(this.guiSendMail);
            this.emailGroup.Controls.Add(this.lblBody);
            this.emailGroup.Controls.Add(this.guiEmailSubject);
            this.emailGroup.Controls.Add(this.lblSubject);
            this.emailGroup.Controls.Add(this.guiEmailTo);
            this.emailGroup.Controls.Add(this.lblEmailTo);
            this.emailGroup.Controls.Add(this.guiEmailFrom);
            this.emailGroup.Controls.Add(this.lblEmailFrom);
            this.emailGroup.Location = new System.Drawing.Point(28, 286);
            this.emailGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailGroup.Name = "emailGroup";
            this.emailGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailGroup.Size = new System.Drawing.Size(1202, 730);
            this.emailGroup.TabIndex = 13;
            this.emailGroup.TabStop = false;
            this.emailGroup.Text = "Email Message";
            this.emailGroup.Enter += new System.EventHandler(this.emailGroup_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(965, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Custom header";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guiSendMail
            // 
            this.guiSendMail.Location = new System.Drawing.Point(955, 611);
            this.guiSendMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiSendMail.Name = "guiSendMail";
            this.guiSendMail.Size = new System.Drawing.Size(195, 39);
            this.guiSendMail.TabIndex = 2;
            this.guiSendMail.Text = "Send Mail";
            this.guiSendMail.UseVisualStyleBackColor = true;
            this.guiSendMail.Click += new System.EventHandler(this.guiSendMail_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(33, 220);
            this.lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(45, 20);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // guiEmailSubject
            // 
            this.guiEmailSubject.Location = new System.Drawing.Point(114, 160);
            this.guiEmailSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiEmailSubject.Name = "guiEmailSubject";
            this.guiEmailSubject.Size = new System.Drawing.Size(667, 26);
            this.guiEmailSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(33, 165);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 20);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            // 
            // guiEmailTo
            // 
            this.guiEmailTo.Location = new System.Drawing.Point(114, 102);
            this.guiEmailTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiEmailTo.Name = "guiEmailTo";
            this.guiEmailTo.Size = new System.Drawing.Size(667, 26);
            this.guiEmailTo.TabIndex = 4;
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Location = new System.Drawing.Point(33, 106);
            this.lblEmailTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(27, 20);
            this.lblEmailTo.TabIndex = 3;
            this.lblEmailTo.Text = "To";
            // 
            // guiEmailFrom
            // 
            this.guiEmailFrom.Enabled = false;
            this.guiEmailFrom.Location = new System.Drawing.Point(114, 43);
            this.guiEmailFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiEmailFrom.Name = "guiEmailFrom";
            this.guiEmailFrom.ReadOnly = true;
            this.guiEmailFrom.Size = new System.Drawing.Size(667, 26);
            this.guiEmailFrom.TabIndex = 2;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(33, 46);
            this.lblEmailFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(46, 20);
            this.lblEmailFrom.TabIndex = 1;
            this.lblEmailFrom.Text = "From";
            // 
            // guiServerName
            // 
            this.guiServerName.Location = new System.Drawing.Point(144, 43);
            this.guiServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiServerName.Name = "guiServerName";
            this.guiServerName.Size = new System.Drawing.Size(432, 26);
            this.guiServerName.TabIndex = 1;
            this.guiServerName.Text = "smtp.office365.com";
            this.guiServerName.TextChanged += new System.EventHandler(this.guiServerName_TextChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(33, 48);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(102, 20);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "SMTP Server";
            // 
            // guiUser
            // 
            this.guiUser.Location = new System.Drawing.Point(326, 102);
            this.guiUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiUser.Name = "guiUser";
            this.guiUser.Size = new System.Drawing.Size(229, 26);
            this.guiUser.TabIndex = 6;
            this.guiUser.Text = "exchange@trabando2020.onmicrosoft.com";
            this.guiUser.TextChanged += new System.EventHandler(this.guiUser_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(228, 106);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 20);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "SMTP User";
            // 
            // guiUseCredentials
            // 
            this.guiUseCredentials.AutoSize = true;
            this.guiUseCredentials.Checked = true;
            this.guiUseCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guiUseCredentials.Location = new System.Drawing.Point(38, 106);
            this.guiUseCredentials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiUseCredentials.Name = "guiUseCredentials";
            this.guiUseCredentials.Size = new System.Drawing.Size(171, 24);
            this.guiUseCredentials.TabIndex = 4;
            this.guiUseCredentials.Text = "Use Authentication";
            this.guiUseCredentials.UseVisualStyleBackColor = true;
            this.guiUseCredentials.CheckedChanged += new System.EventHandler(this.guiUseCredentials_CheckedChanged);
            // 
            // guiPort
            // 
            this.guiPort.Location = new System.Drawing.Point(674, 43);
            this.guiPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiPort.Name = "guiPort";
            this.guiPort.Size = new System.Drawing.Size(108, 26);
            this.guiPort.TabIndex = 3;
            this.guiPort.Text = "587";
            // 
            // guiUseSsl
            // 
            this.guiUseSsl.AutoSize = true;
            this.guiUseSsl.Checked = true;
            this.guiUseSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.guiUseSsl.Location = new System.Drawing.Point(38, 149);
            this.guiUseSsl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiUseSsl.Name = "guiUseSsl";
            this.guiUseSsl.Size = new System.Drawing.Size(99, 24);
            this.guiUseSsl.TabIndex = 9;
            this.guiUseSsl.Text = "Use SSL";
            this.guiUseSsl.UseVisualStyleBackColor = true;
            // 
            // guiPassword
            // 
            this.guiPassword.Location = new System.Drawing.Point(651, 102);
            this.guiPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guiPassword.Name = "guiPassword";
            this.guiPassword.Size = new System.Drawing.Size(128, 26);
            this.guiPassword.TabIndex = 8;
            this.guiPassword.Text = "TTrr1990??";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(567, 106);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(628, 48);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // serverGroup
            // 
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
            this.serverGroup.Location = new System.Drawing.Point(28, 53);
            this.serverGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverGroup.Size = new System.Drawing.Size(810, 205);
            this.serverGroup.TabIndex = 12;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "SMTP Configuration";
            // 
            // snd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailGroup);
            this.Controls.Add(this.serverGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "snd";
            this.Text = "snd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.snd_Load);
            this.emailGroup.ResumeLayout(false);
            this.emailGroup.PerformLayout();
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Zoople.HTMLEditControl htmlEditControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox emailGroup;
        private System.Windows.Forms.Button guiSendMail;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox guiEmailSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox guiEmailTo;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox guiEmailFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.TextBox guiServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox guiUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox guiUseCredentials;
        private System.Windows.Forms.TextBox guiPort;
        private System.Windows.Forms.CheckBox guiUseSsl;
        private System.Windows.Forms.TextBox guiPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}