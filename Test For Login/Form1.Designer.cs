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
			this.panel2 = new System.Windows.Forms.Panel();
			this.adminMessageLabel = new System.Windows.Forms.Label();
			this.userMsgsListBox = new System.Windows.Forms.ListBox();
			this.userShowMsgsButton = new System.Windows.Forms.Button();
			this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
			this.sendMsgButton = new System.Windows.Forms.Button();
			this.enterMsgLabel = new System.Windows.Forms.Label();
			this.msgBox = new System.Windows.Forms.TextBox();
			this.accountInfoLabel = new System.Windows.Forms.Label();
			this.signOutButton = new System.Windows.Forms.Button();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel3 = new System.Windows.Forms.Panel();
			this.adminMsgsListBox = new System.Windows.Forms.ListBox();
			this.showAdminMsgsButton = new System.Windows.Forms.Button();
			this.adminSignOutButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.companyMsgBox = new System.Windows.Forms.TextBox();
			this.updateCompanyMsgButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.adminMessageLabel);
			this.panel2.Controls.Add(this.userMsgsListBox);
			this.panel2.Controls.Add(this.userShowMsgsButton);
			this.panel2.Controls.Add(this.anonymousCheckBox);
			this.panel2.Controls.Add(this.sendMsgButton);
			this.panel2.Controls.Add(this.enterMsgLabel);
			this.panel2.Controls.Add(this.msgBox);
			this.panel2.Controls.Add(this.accountInfoLabel);
			this.panel2.Controls.Add(this.signOutButton);
			this.panel2.Location = new System.Drawing.Point(22, 17);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(751, 203);
			this.panel2.TabIndex = 12;
			this.panel2.Visible = false;
			// 
			// adminMessageLabel
			// 
			this.adminMessageLabel.AutoSize = true;
			this.adminMessageLabel.Location = new System.Drawing.Point(10, 45);
			this.adminMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.adminMessageLabel.Name = "adminMessageLabel";
			this.adminMessageLabel.Size = new System.Drawing.Size(218, 17);
			this.adminMessageLabel.TabIndex = 8;
			this.adminMessageLabel.Text = "Latest admin message goes here";
			// 
			// userMsgsListBox
			// 
			this.userMsgsListBox.FormattingEnabled = true;
			this.userMsgsListBox.ItemHeight = 16;
			this.userMsgsListBox.Location = new System.Drawing.Point(500, 24);
			this.userMsgsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.userMsgsListBox.Name = "userMsgsListBox";
			this.userMsgsListBox.Size = new System.Drawing.Size(253, 84);
			this.userMsgsListBox.TabIndex = 7;
			this.userMsgsListBox.DoubleClick += new System.EventHandler(this.userMsgListBox_DoubleClick);
			// 
			// userShowMsgsButton
			// 
			this.userShowMsgsButton.Location = new System.Drawing.Point(572, 117);
			this.userShowMsgsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.userShowMsgsButton.Name = "userShowMsgsButton";
			this.userShowMsgsButton.Size = new System.Drawing.Size(138, 31);
			this.userShowMsgsButton.TabIndex = 6;
			this.userShowMsgsButton.Text = "Show my messages";
			this.userShowMsgsButton.UseVisualStyleBackColor = true;
			this.userShowMsgsButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// anonymousCheckBox
			// 
			this.anonymousCheckBox.AutoSize = true;
			this.anonymousCheckBox.Location = new System.Drawing.Point(74, 131);
			this.anonymousCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.anonymousCheckBox.Name = "anonymousCheckBox";
			this.anonymousCheckBox.Size = new System.Drawing.Size(202, 21);
			this.anonymousCheckBox.TabIndex = 5;
			this.anonymousCheckBox.Text = "Make message anonymous";
			this.anonymousCheckBox.UseVisualStyleBackColor = true;
			// 
			// sendMsgButton
			// 
			this.sendMsgButton.Location = new System.Drawing.Point(282, 131);
			this.sendMsgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.sendMsgButton.Name = "sendMsgButton";
			this.sendMsgButton.Size = new System.Drawing.Size(162, 21);
			this.sendMsgButton.TabIndex = 4;
			this.sendMsgButton.Text = "Send message";
			this.sendMsgButton.UseVisualStyleBackColor = true;
			this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
			// 
			// enterMsgLabel
			// 
			this.enterMsgLabel.AutoSize = true;
			this.enterMsgLabel.Location = new System.Drawing.Point(72, 101);
			this.enterMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.enterMsgLabel.Name = "enterMsgLabel";
			this.enterMsgLabel.Size = new System.Drawing.Size(140, 17);
			this.enterMsgLabel.TabIndex = 3;
			this.enterMsgLabel.Text = "Enter message here:";
			// 
			// msgBox
			// 
			this.msgBox.Location = new System.Drawing.Point(222, 100);
			this.msgBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.msgBox.Name = "msgBox";
			this.msgBox.Size = new System.Drawing.Size(223, 22);
			this.msgBox.TabIndex = 2;
			// 
			// accountInfoLabel
			// 
			this.accountInfoLabel.AutoSize = true;
			this.accountInfoLabel.Location = new System.Drawing.Point(8, 6);
			this.accountInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.accountInfoLabel.Name = "accountInfoLabel";
			this.accountInfoLabel.Size = new System.Drawing.Size(119, 17);
			this.accountInfoLabel.TabIndex = 1;
			this.accountInfoLabel.Text = "No user signed in";
			// 
			// signOutButton
			// 
			this.signOutButton.Location = new System.Drawing.Point(577, 153);
			this.signOutButton.Name = "signOutButton";
			this.signOutButton.Size = new System.Drawing.Size(171, 23);
			this.signOutButton.TabIndex = 0;
			this.signOutButton.Text = "Sign Out";
			this.signOutButton.UseVisualStyleBackColor = true;
			this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.updateCompanyMsgButton);
			this.panel3.Controls.Add(this.companyMsgBox);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.adminSignOutButton);
			this.panel3.Controls.Add(this.showAdminMsgsButton);
			this.panel3.Controls.Add(this.adminMsgsListBox);
			this.panel3.Location = new System.Drawing.Point(831, 235);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(760, 250);
			this.panel3.TabIndex = 13;
			this.panel3.Visible = false;
			// 
			// adminMsgsListBox
			// 
			this.adminMsgsListBox.FormattingEnabled = true;
			this.adminMsgsListBox.ItemHeight = 16;
			this.adminMsgsListBox.Location = new System.Drawing.Point(212, 34);
			this.adminMsgsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.adminMsgsListBox.Name = "adminMsgsListBox";
			this.adminMsgsListBox.Size = new System.Drawing.Size(347, 84);
			this.adminMsgsListBox.TabIndex = 0;
			this.adminMsgsListBox.DoubleClick += new System.EventHandler(this.adminMsgsListBox_DoubleClick);
			// 
			// showAdminMsgsButton
			// 
			this.showAdminMsgsButton.Location = new System.Drawing.Point(11, 12);
			this.showAdminMsgsButton.Margin = new System.Windows.Forms.Padding(2);
			this.showAdminMsgsButton.Name = "showAdminMsgsButton";
			this.showAdminMsgsButton.Size = new System.Drawing.Size(142, 39);
			this.showAdminMsgsButton.TabIndex = 1;
			this.showAdminMsgsButton.Text = "Show Messages";
			this.showAdminMsgsButton.UseVisualStyleBackColor = true;
			this.showAdminMsgsButton.Click += new System.EventHandler(this.showMsgsButton_Click);
			// 
			// adminSignOutButton
			// 
			this.adminSignOutButton.Location = new System.Drawing.Point(11, 82);
			this.adminSignOutButton.Margin = new System.Windows.Forms.Padding(2);
			this.adminSignOutButton.Name = "adminSignOutButton";
			this.adminSignOutButton.Size = new System.Drawing.Size(142, 30);
			this.adminSignOutButton.TabIndex = 2;
			this.adminSignOutButton.Text = "Sign out";
			this.adminSignOutButton.UseVisualStyleBackColor = true;
			this.adminSignOutButton.Click += new System.EventHandler(this.adminSignOutButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 182);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Update company message:";
			// 
			// companyMsgBox
			// 
			this.companyMsgBox.Location = new System.Drawing.Point(212, 179);
			this.companyMsgBox.Margin = new System.Windows.Forms.Padding(2);
			this.companyMsgBox.Name = "companyMsgBox";
			this.companyMsgBox.Size = new System.Drawing.Size(347, 22);
			this.companyMsgBox.TabIndex = 4;
			// 
			// updateCompanyMsgButton
			// 
			this.updateCompanyMsgButton.Location = new System.Drawing.Point(478, 210);
			this.updateCompanyMsgButton.Margin = new System.Windows.Forms.Padding(2);
			this.updateCompanyMsgButton.Name = "updateCompanyMsgButton";
			this.updateCompanyMsgButton.Size = new System.Drawing.Size(79, 25);
			this.updateCompanyMsgButton.TabIndex = 5;
			this.updateCompanyMsgButton.Text = "send";
			this.updateCompanyMsgButton.UseVisualStyleBackColor = true;
			this.updateCompanyMsgButton.Click += new System.EventHandler(this.updateCompanyMessageButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(210, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Messages from employees:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 533);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Name = "Form1";
			this.Text = "d";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label accountInfoLabel;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label enterMsgLabel;
        private System.Windows.Forms.CheckBox anonymousCheckBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button userShowMsgsButton;
        private System.Windows.Forms.ListBox userMsgsListBox;
        private System.Windows.Forms.Label adminMessageLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button updateCompanyMsgButton;
		private System.Windows.Forms.TextBox companyMsgBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button adminSignOutButton;
		private System.Windows.Forms.Button showAdminMsgsButton;
		private System.Windows.Forms.ListBox adminMsgsListBox;
	}
}

