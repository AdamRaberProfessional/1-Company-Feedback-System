namespace Test_For_Login
{
	partial class Form1
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.verifyPasswordBox = new System.Windows.Forms.TextBox();
            this.verifyPasswordLabel = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountTypeBox = new System.Windows.Forms.ComboBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.enterMsgLabel = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.accountInfoLabel = new System.Windows.Forms.Label();
            this.signOutButton = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminSignOutButton = new System.Windows.Forms.Button();
            this.showMsgsButton = new System.Windows.Forms.Button();
            this.msgsListBox = new System.Windows.Forms.ListBox();
            this.userShowMsgsButton = new System.Windows.Forms.Button();
            this.userMsgsListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(388, 10);
            this.emailBox.Margin = new System.Windows.Forms.Padding(6);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(338, 38);
            this.emailBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(388, 64);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(338, 38);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(16, 12);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(87, 32);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(388, 225);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(338, 66);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 74);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(139, 32);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(794, 74);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(346, 54);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // verifyPasswordBox
            // 
            this.verifyPasswordBox.Location = new System.Drawing.Point(388, 120);
            this.verifyPasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.verifyPasswordBox.Name = "verifyPasswordBox";
            this.verifyPasswordBox.Size = new System.Drawing.Size(338, 38);
            this.verifyPasswordBox.TabIndex = 7;
            this.verifyPasswordBox.Visible = false;
            // 
            // verifyPasswordLabel
            // 
            this.verifyPasswordLabel.AutoSize = true;
            this.verifyPasswordLabel.Location = new System.Drawing.Point(16, 126);
            this.verifyPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verifyPasswordLabel.Name = "verifyPasswordLabel";
            this.verifyPasswordLabel.Size = new System.Drawing.Size(219, 32);
            this.verifyPasswordLabel.TabIndex = 8;
            this.verifyPasswordLabel.Text = "Verify Password";
            this.verifyPasswordLabel.Visible = false;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Location = new System.Drawing.Point(788, 16);
            this.createAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(623, 32);
            this.createAccountLabel.TabIndex = 9;
            this.createAccountLabel.Text = "Don\'t have an account? Click here to create one ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accountTypeBox);
            this.panel1.Controls.Add(this.accountTypeLabel);
            this.panel1.Controls.Add(this.createAccountLabel);
            this.panel1.Controls.Add(this.verifyPasswordLabel);
            this.panel1.Controls.Add(this.verifyPasswordBox);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Location = new System.Drawing.Point(52, 439);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 356);
            this.panel1.TabIndex = 11;
            // 
            // accountTypeBox
            // 
            this.accountTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeBox.FormattingEnabled = true;
            this.accountTypeBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.accountTypeBox.Location = new System.Drawing.Point(388, 172);
            this.accountTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountTypeBox.MaxDropDownItems = 2;
            this.accountTypeBox.Name = "accountTypeBox";
            this.accountTypeBox.Size = new System.Drawing.Size(338, 39);
            this.accountTypeBox.TabIndex = 13;
            this.accountTypeBox.Visible = false;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(22, 176);
            this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(188, 32);
            this.accountTypeLabel.TabIndex = 11;
            this.accountTypeLabel.Text = "Account Type";
            this.accountTypeLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userMsgsListBox);
            this.panel2.Controls.Add(this.userShowMsgsButton);
            this.panel2.Controls.Add(this.anonymousCheckBox);
            this.panel2.Controls.Add(this.sendMsgButton);
            this.panel2.Controls.Add(this.enterMsgLabel);
            this.panel2.Controls.Add(this.msgBox);
            this.panel2.Controls.Add(this.accountInfoLabel);
            this.panel2.Controls.Add(this.signOutButton);
            this.panel2.Location = new System.Drawing.Point(43, 401);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 394);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // anonymousCheckBox
            // 
            this.anonymousCheckBox.AutoSize = true;
            this.anonymousCheckBox.Location = new System.Drawing.Point(149, 253);
            this.anonymousCheckBox.Name = "anonymousCheckBox";
            this.anonymousCheckBox.Size = new System.Drawing.Size(398, 36);
            this.anonymousCheckBox.TabIndex = 5;
            this.anonymousCheckBox.Text = "Make message anonymous";
            this.anonymousCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(563, 253);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(324, 41);
            this.sendMsgButton.TabIndex = 4;
            this.sendMsgButton.Text = "Send message";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // enterMsgLabel
            // 
            this.enterMsgLabel.AutoSize = true;
            this.enterMsgLabel.Location = new System.Drawing.Point(143, 196);
            this.enterMsgLabel.Name = "enterMsgLabel";
            this.enterMsgLabel.Size = new System.Drawing.Size(277, 32);
            this.enterMsgLabel.TabIndex = 3;
            this.enterMsgLabel.Text = "Enter message here:";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(445, 193);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(442, 38);
            this.msgBox.TabIndex = 2;
            // 
            // accountInfoLabel
            // 
            this.accountInfoLabel.AutoSize = true;
            this.accountInfoLabel.Location = new System.Drawing.Point(16, 12);
            this.accountInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountInfoLabel.Name = "accountInfoLabel";
            this.accountInfoLabel.Size = new System.Drawing.Size(235, 32);
            this.accountInfoLabel.TabIndex = 1;
            this.accountInfoLabel.Text = "No user signed in";
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(1154, 297);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(342, 45);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminSignOutButton);
            this.panel3.Controls.Add(this.showMsgsButton);
            this.panel3.Controls.Add(this.msgsListBox);
            this.panel3.Location = new System.Drawing.Point(44, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1520, 346);
            this.panel3.TabIndex = 13;
            this.panel3.Visible = false;
            // 
            // adminSignOutButton
            // 
            this.adminSignOutButton.Location = new System.Drawing.Point(1153, 198);
            this.adminSignOutButton.Name = "adminSignOutButton";
            this.adminSignOutButton.Size = new System.Drawing.Size(266, 58);
            this.adminSignOutButton.TabIndex = 2;
            this.adminSignOutButton.Text = "Sign out";
            this.adminSignOutButton.UseVisualStyleBackColor = true;
            this.adminSignOutButton.Click += new System.EventHandler(this.adminSignOutButton_Click);
            // 
            // showMsgsButton
            // 
            this.showMsgsButton.Location = new System.Drawing.Point(36, 181);
            this.showMsgsButton.Name = "showMsgsButton";
            this.showMsgsButton.Size = new System.Drawing.Size(283, 75);
            this.showMsgsButton.TabIndex = 1;
            this.showMsgsButton.Text = "Show Messages";
            this.showMsgsButton.UseVisualStyleBackColor = true;
            this.showMsgsButton.Click += new System.EventHandler(this.showMsgsButton_Click);
            // 
            // msgsListBox
            // 
            this.msgsListBox.FormattingEnabled = true;
            this.msgsListBox.ItemHeight = 31;
            this.msgsListBox.Location = new System.Drawing.Point(425, 159);
            this.msgsListBox.Name = "msgsListBox";
            this.msgsListBox.Size = new System.Drawing.Size(690, 159);
            this.msgsListBox.TabIndex = 0;
            this.msgsListBox.DoubleClick += new System.EventHandler(this.msgsListBox_DoubleClick);
            // 
            // userShowMsgsButton
            // 
            this.userShowMsgsButton.Location = new System.Drawing.Point(1144, 227);
            this.userShowMsgsButton.Name = "userShowMsgsButton";
            this.userShowMsgsButton.Size = new System.Drawing.Size(276, 61);
            this.userShowMsgsButton.TabIndex = 6;
            this.userShowMsgsButton.Text = "Show my messages";
            this.userShowMsgsButton.UseVisualStyleBackColor = true;
            this.userShowMsgsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userMsgsListBox
            // 
            this.userMsgsListBox.FormattingEnabled = true;
            this.userMsgsListBox.ItemHeight = 31;
            this.userMsgsListBox.Location = new System.Drawing.Point(1000, 47);
            this.userMsgsListBox.Name = "userMsgsListBox";
            this.userMsgsListBox.Size = new System.Drawing.Size(502, 159);
            this.userMsgsListBox.TabIndex = 7;
            this.userMsgsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 810);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "d";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox emailBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox verifyPasswordBox;
        private System.Windows.Forms.Label verifyPasswordLabel;
        private System.Windows.Forms.Label createAccountLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label accountInfoLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.ComboBox accountTypeBox;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label enterMsgLabel;
        private System.Windows.Forms.CheckBox anonymousCheckBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button showMsgsButton;
        private System.Windows.Forms.ListBox msgsListBox;
        private System.Windows.Forms.Button adminSignOutButton;
        private System.Windows.Forms.Button userShowMsgsButton;
        private System.Windows.Forms.ListBox userMsgsListBox;
    }
}

