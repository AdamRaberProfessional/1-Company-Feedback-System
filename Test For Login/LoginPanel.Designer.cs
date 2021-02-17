namespace Test_For_Login
{
	partial class LoginPanel
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.verifyPasswordLabel = new System.Windows.Forms.Label();
			this.verifyPasswordBox = new System.Windows.Forms.TextBox();
			this.signUpCodeBox = new System.Windows.Forms.TextBox();
			this.accountTypeLabel = new System.Windows.Forms.Label();
			this.createAccountLabel = new System.Windows.Forms.Label();
			this.createAccountButton = new System.Windows.Forms.Button();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.emailLabel = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.emailBox = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(23, 265);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(567, 150);
			this.panel1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 213);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "sign-up codes will be 00ADMIN00 or 00USER00";
			this.label1.Visible = false;
			// 
			// verifyPasswordLabel
			// 
			this.verifyPasswordLabel.AutoSize = true;
			this.verifyPasswordLabel.Location = new System.Drawing.Point(20, 68);
			this.verifyPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.verifyPasswordLabel.Name = "verifyPasswordLabel";
			this.verifyPasswordLabel.Size = new System.Drawing.Size(82, 13);
			this.verifyPasswordLabel.TabIndex = 8;
			this.verifyPasswordLabel.Text = "Verify Password";
			this.verifyPasswordLabel.Visible = false;
			// 
			// verifyPasswordBox
			// 
			this.verifyPasswordBox.Location = new System.Drawing.Point(160, 65);
			this.verifyPasswordBox.Margin = new System.Windows.Forms.Padding(2);
			this.verifyPasswordBox.Name = "verifyPasswordBox";
			this.verifyPasswordBox.Size = new System.Drawing.Size(129, 20);
			this.verifyPasswordBox.TabIndex = 2;
			this.verifyPasswordBox.UseSystemPasswordChar = true;
			this.verifyPasswordBox.Visible = false;
			// 
			// signUpCodeBox
			// 
			this.signUpCodeBox.Location = new System.Drawing.Point(160, 90);
			this.signUpCodeBox.Margin = new System.Windows.Forms.Padding(2);
			this.signUpCodeBox.Name = "signUpCodeBox";
			this.signUpCodeBox.Size = new System.Drawing.Size(129, 20);
			this.signUpCodeBox.TabIndex = 3;
			this.signUpCodeBox.Visible = false;
			// 
			// accountTypeLabel
			// 
			this.accountTypeLabel.AutoSize = true;
			this.accountTypeLabel.Location = new System.Drawing.Point(20, 94);
			this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.accountTypeLabel.Name = "accountTypeLabel";
			this.accountTypeLabel.Size = new System.Drawing.Size(70, 13);
			this.accountTypeLabel.TabIndex = 11;
			this.accountTypeLabel.Text = "Sign-up code";
			this.accountTypeLabel.Visible = false;
			// 
			// createAccountLabel
			// 
			this.createAccountLabel.AutoSize = true;
			this.createAccountLabel.Location = new System.Drawing.Point(33, 156);
			this.createAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.createAccountLabel.Name = "createAccountLabel";
			this.createAccountLabel.Size = new System.Drawing.Size(241, 13);
			this.createAccountLabel.TabIndex = 9;
			this.createAccountLabel.Text = "Don\'t have an account? Click here to create one ";
			// 
			// createAccountButton
			// 
			this.createAccountButton.Location = new System.Drawing.Point(86, 180);
			this.createAccountButton.Margin = new System.Windows.Forms.Padding(2);
			this.createAccountButton.Name = "createAccountButton";
			this.createAccountButton.Size = new System.Drawing.Size(130, 23);
			this.createAccountButton.TabIndex = 6;
			this.createAccountButton.Text = "Create Account";
			this.createAccountButton.UseVisualStyleBackColor = true;
			this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(20, 45);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 4;
			this.passwordLabel.Text = "Password";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(160, 115);
			this.loginButton.Margin = new System.Windows.Forms.Padding(2);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(129, 22);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(20, 19);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(32, 13);
			this.emailLabel.TabIndex = 2;
			this.emailLabel.Text = "Email";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(160, 41);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(129, 20);
			this.passwordBox.TabIndex = 1;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(160, 18);
			this.emailBox.Margin = new System.Windows.Forms.Padding(2);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(129, 20);
			this.emailBox.TabIndex = 0;
			// 
			// LoginPanel
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 295);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.verifyPasswordLabel);
			this.Controls.Add(this.verifyPasswordBox);
			this.Controls.Add(this.createAccountLabel);
			this.Controls.Add(this.signUpCodeBox);
			this.Controls.Add(this.createAccountButton);
			this.Controls.Add(this.accountTypeLabel);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.passwordLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LoginPanel";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox signUpCodeBox;
		private System.Windows.Forms.Label accountTypeLabel;
		private System.Windows.Forms.Label createAccountLabel;
		private System.Windows.Forms.Label verifyPasswordLabel;
		private System.Windows.Forms.TextBox verifyPasswordBox;
		private System.Windows.Forms.Button createAccountButton;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.TextBox emailBox;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}