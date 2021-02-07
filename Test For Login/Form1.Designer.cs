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
            this.panel2 = new System.Windows.Forms.Panel();
            this.accountInfoLabel = new System.Windows.Forms.Label();
            this.signOutButton = new System.Windows.Forms.Button();
            this.databaseMessageLabel = new System.Windows.Forms.Label();
            this.databaseMessageBox = new System.Windows.Forms.TextBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.passwordBox.Size = new System.Drawing.Size(338, 38);
            this.passwordBox.TabIndex = 1;
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
            this.loginButton.Location = new System.Drawing.Point(388, 209);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(338, 66);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
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
            this.createAccountButton.Click += new System.EventHandler(this.button3_Click);
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
            this.verifyPasswordLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.panel1.Controls.Add(this.createAccountLabel);
            this.panel1.Controls.Add(this.verifyPasswordLabel);
            this.panel1.Controls.Add(this.verifyPasswordBox);
            this.panel1.Controls.Add(this.createAccountButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Location = new System.Drawing.Point(8, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 298);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addDataButton);
            this.panel2.Controls.Add(this.databaseMessageBox);
            this.panel2.Controls.Add(this.databaseMessageLabel);
            this.panel2.Controls.Add(this.accountInfoLabel);
            this.panel2.Controls.Add(this.signOutButton);
            this.panel2.Location = new System.Drawing.Point(15, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1502, 407);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // accountInfoLabel
            // 
            this.accountInfoLabel.AutoSize = true;
            this.accountInfoLabel.Location = new System.Drawing.Point(317, 86);
            this.accountInfoLabel.Name = "accountInfoLabel";
            this.accountInfoLabel.Size = new System.Drawing.Size(235, 32);
            this.accountInfoLabel.TabIndex = 1;
            this.accountInfoLabel.Text = "No user signed in";
            this.accountInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(301, 201);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(6);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(342, 45);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // databaseMessageLabel
            // 
            this.databaseMessageLabel.AutoSize = true;
            this.databaseMessageLabel.Location = new System.Drawing.Point(895, 112);
            this.databaseMessageLabel.Name = "databaseMessageLabel";
            this.databaseMessageLabel.Size = new System.Drawing.Size(394, 32);
            this.databaseMessageLabel.TabIndex = 2;
            this.databaseMessageLabel.Text = "Enter database message here";
            // 
            // databaseMessageBox
            // 
            this.databaseMessageBox.Location = new System.Drawing.Point(901, 173);
            this.databaseMessageBox.Name = "databaseMessageBox";
            this.databaseMessageBox.Size = new System.Drawing.Size(388, 38);
            this.databaseMessageBox.TabIndex = 3;
            this.databaseMessageBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(899, 236);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(390, 60);
            this.addDataButton.TabIndex = 4;
            this.addDataButton.Text = "Add to database";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.enterMessageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 810);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

