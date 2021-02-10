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
			this.addDataButton = new System.Windows.Forms.Button();
			this.databaseMessageBox = new System.Windows.Forms.TextBox();
			this.databaseMessageLabel = new System.Windows.Forms.Label();
			this.accountInfoLabel = new System.Windows.Forms.Label();
			this.signOutButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(194, 5);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(171, 22);
			this.emailBox.TabIndex = 0;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(194, 33);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(171, 22);
			this.passwordBox.TabIndex = 1;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(8, 6);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(42, 17);
			this.emailLabel.TabIndex = 2;
			this.emailLabel.Text = "Email";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(194, 116);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(169, 34);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(8, 38);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(69, 17);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "Password";
			// 
			// createAccountButton
			// 
			this.createAccountButton.Location = new System.Drawing.Point(397, 38);
			this.createAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.createAccountButton.Name = "createAccountButton";
			this.createAccountButton.Size = new System.Drawing.Size(173, 28);
			this.createAccountButton.TabIndex = 6;
			this.createAccountButton.Text = "Create Account";
			this.createAccountButton.UseVisualStyleBackColor = true;
			this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
			// 
			// verifyPasswordBox
			// 
			this.verifyPasswordBox.Location = new System.Drawing.Point(194, 62);
			this.verifyPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.verifyPasswordBox.Name = "verifyPasswordBox";
			this.verifyPasswordBox.Size = new System.Drawing.Size(171, 22);
			this.verifyPasswordBox.TabIndex = 7;
			this.verifyPasswordBox.Visible = false;
			// 
			// verifyPasswordLabel
			// 
			this.verifyPasswordLabel.AutoSize = true;
			this.verifyPasswordLabel.Location = new System.Drawing.Point(8, 65);
			this.verifyPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.verifyPasswordLabel.Name = "verifyPasswordLabel";
			this.verifyPasswordLabel.Size = new System.Drawing.Size(109, 17);
			this.verifyPasswordLabel.TabIndex = 8;
			this.verifyPasswordLabel.Text = "Verify Password";
			this.verifyPasswordLabel.Visible = false;
			// 
			// createAccountLabel
			// 
			this.createAccountLabel.AutoSize = true;
			this.createAccountLabel.Location = new System.Drawing.Point(394, 8);
			this.createAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.createAccountLabel.Name = "createAccountLabel";
			this.createAccountLabel.Size = new System.Drawing.Size(316, 17);
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
			this.panel1.Location = new System.Drawing.Point(13, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(756, 184);
			this.panel1.TabIndex = 11;
			// 
			// accountTypeBox
			// 
			this.accountTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.accountTypeBox.FormattingEnabled = true;
			this.accountTypeBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.accountTypeBox.Location = new System.Drawing.Point(194, 89);
			this.accountTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.accountTypeBox.MaxDropDownItems = 2;
			this.accountTypeBox.Name = "accountTypeBox";
			this.accountTypeBox.Size = new System.Drawing.Size(171, 24);
			this.accountTypeBox.TabIndex = 13;
			this.accountTypeBox.Visible = false;
			// 
			// accountTypeLabel
			// 
			this.accountTypeLabel.AutoSize = true;
			this.accountTypeLabel.Location = new System.Drawing.Point(11, 91);
			this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.accountTypeLabel.Name = "accountTypeLabel";
			this.accountTypeLabel.Size = new System.Drawing.Size(95, 17);
			this.accountTypeLabel.TabIndex = 11;
			this.accountTypeLabel.Text = "Account Type";
			this.accountTypeLabel.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.addDataButton);
			this.panel2.Controls.Add(this.databaseMessageBox);
			this.panel2.Controls.Add(this.databaseMessageLabel);
			this.panel2.Controls.Add(this.accountInfoLabel);
			this.panel2.Controls.Add(this.signOutButton);
			this.panel2.Location = new System.Drawing.Point(13, 220);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(751, 185);
			this.panel2.TabIndex = 12;
			this.panel2.Visible = false;
			// 
			// addDataButton
			// 
			this.addDataButton.Location = new System.Drawing.Point(450, 122);
			this.addDataButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addDataButton.Name = "addDataButton";
			this.addDataButton.Size = new System.Drawing.Size(195, 31);
			this.addDataButton.TabIndex = 4;
			this.addDataButton.Text = "Add to database";
			this.addDataButton.UseVisualStyleBackColor = true;
			this.addDataButton.Click += new System.EventHandler(this.enterMessageButton_Click);
			// 
			// databaseMessageBox
			// 
			this.databaseMessageBox.Location = new System.Drawing.Point(450, 89);
			this.databaseMessageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.databaseMessageBox.Name = "databaseMessageBox";
			this.databaseMessageBox.Size = new System.Drawing.Size(196, 22);
			this.databaseMessageBox.TabIndex = 3;
			// 
			// databaseMessageLabel
			// 
			this.databaseMessageLabel.AutoSize = true;
			this.databaseMessageLabel.Location = new System.Drawing.Point(448, 58);
			this.databaseMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.databaseMessageLabel.Name = "databaseMessageLabel";
			this.databaseMessageLabel.Size = new System.Drawing.Size(199, 17);
			this.databaseMessageLabel.TabIndex = 2;
			this.databaseMessageLabel.Text = "Enter database message here";
			// 
			// accountInfoLabel
			// 
			this.accountInfoLabel.AutoSize = true;
			this.accountInfoLabel.Location = new System.Drawing.Point(158, 44);
			this.accountInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.accountInfoLabel.Name = "accountInfoLabel";
			this.accountInfoLabel.Size = new System.Drawing.Size(119, 17);
			this.accountInfoLabel.TabIndex = 1;
			this.accountInfoLabel.Text = "No user signed in";
			// 
			// signOutButton
			// 
			this.signOutButton.Location = new System.Drawing.Point(150, 104);
			this.signOutButton.Name = "signOutButton";
			this.signOutButton.Size = new System.Drawing.Size(171, 23);
			this.signOutButton.TabIndex = 0;
			this.signOutButton.Text = "Sign Out";
			this.signOutButton.UseVisualStyleBackColor = true;
			this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 31);
			this.button1.TabIndex = 14;
			this.button1.Text = "Test Pull";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 418);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "d";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox databaseMessageBox;
        private System.Windows.Forms.Label databaseMessageLabel;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.ComboBox accountTypeBox;
		private System.Windows.Forms.Button button1;
	}
}

