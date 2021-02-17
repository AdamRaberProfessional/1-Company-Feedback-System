namespace Test_For_Login
{
	partial class UserPanel
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
			this.feedbackBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.adminMessageLabel = new System.Windows.Forms.Label();
			this.userMsgsListBox = new System.Windows.Forms.ListBox();
			this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
			this.sendMsgButton = new System.Windows.Forms.Button();
			this.enterMsgLabel = new System.Windows.Forms.Label();
			this.accountInfoLabel = new System.Windows.Forms.Label();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.updateCompanyMsgButton = new System.Windows.Forms.Button();
			this.companyMsgBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.adminSignOutButton = new System.Windows.Forms.Button();
			this.showAdminMsgsButton = new System.Windows.Forms.Button();
			this.adminMsgsListBox = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.feedbackBox);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.adminMessageLabel);
			this.panel2.Controls.Add(this.userMsgsListBox);
			this.panel2.Controls.Add(this.anonymousCheckBox);
			this.panel2.Controls.Add(this.sendMsgButton);
			this.panel2.Controls.Add(this.enterMsgLabel);
			this.panel2.Controls.Add(this.accountInfoLabel);
			this.panel2.Location = new System.Drawing.Point(11, 26);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(679, 309);
			this.panel2.TabIndex = 12;
			this.panel2.Visible = false;
			// 
			// feedbackBox
			// 
			this.feedbackBox.Location = new System.Drawing.Point(260, 96);
			this.feedbackBox.Name = "feedbackBox";
			this.feedbackBox.Size = new System.Drawing.Size(394, 118);
			this.feedbackBox.TabIndex = 10;
			this.feedbackBox.Text = "What\'s one thing you like about working here?\n\n\nWhats one thing we can improve, a" +
    "nd how can we improve it?\n\n\nAny other suggestions?";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Feedback History";
			// 
			// adminMessageLabel
			// 
			this.adminMessageLabel.AutoSize = true;
			this.adminMessageLabel.Location = new System.Drawing.Point(8, 37);
			this.adminMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.adminMessageLabel.Name = "adminMessageLabel";
			this.adminMessageLabel.Size = new System.Drawing.Size(162, 13);
			this.adminMessageLabel.TabIndex = 8;
			this.adminMessageLabel.Text = "Latest admin message goes here";
			// 
			// userMsgsListBox
			// 
			this.userMsgsListBox.FormattingEnabled = true;
			this.userMsgsListBox.Location = new System.Drawing.Point(11, 97);
			this.userMsgsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.userMsgsListBox.Name = "userMsgsListBox";
			this.userMsgsListBox.Size = new System.Drawing.Size(191, 95);
			this.userMsgsListBox.TabIndex = 7;
			this.userMsgsListBox.Click += new System.EventHandler(this.userMsgListBox_Click);
			// 
			// anonymousCheckBox
			// 
			this.anonymousCheckBox.AutoSize = true;
			this.anonymousCheckBox.Location = new System.Drawing.Point(261, 226);
			this.anonymousCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.anonymousCheckBox.Name = "anonymousCheckBox";
			this.anonymousCheckBox.Size = new System.Drawing.Size(158, 17);
			this.anonymousCheckBox.TabIndex = 5;
			this.anonymousCheckBox.Text = "Make feedback anonymous";
			this.anonymousCheckBox.UseVisualStyleBackColor = true;
			// 
			// sendMsgButton
			// 
			this.sendMsgButton.Location = new System.Drawing.Point(532, 219);
			this.sendMsgButton.Margin = new System.Windows.Forms.Padding(2);
			this.sendMsgButton.Name = "sendMsgButton";
			this.sendMsgButton.Size = new System.Drawing.Size(122, 28);
			this.sendMsgButton.TabIndex = 4;
			this.sendMsgButton.Text = "Send feedback";
			this.sendMsgButton.UseVisualStyleBackColor = true;
			this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
			// 
			// enterMsgLabel
			// 
			this.enterMsgLabel.AutoSize = true;
			this.enterMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterMsgLabel.Location = new System.Drawing.Point(257, 73);
			this.enterMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.enterMsgLabel.Name = "enterMsgLabel";
			this.enterMsgLabel.Size = new System.Drawing.Size(227, 20);
			this.enterMsgLabel.TabIndex = 3;
			this.enterMsgLabel.Text = "Enter feedback message here:";
			// 
			// accountInfoLabel
			// 
			this.accountInfoLabel.AutoSize = true;
			this.accountInfoLabel.Location = new System.Drawing.Point(6, 5);
			this.accountInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.accountInfoLabel.Name = "accountInfoLabel";
			this.accountInfoLabel.Size = new System.Drawing.Size(89, 13);
			this.accountInfoLabel.TabIndex = 1;
			this.accountInfoLabel.Text = "No user signed in";
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
			this.panel3.Location = new System.Drawing.Point(61, 356);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(570, 203);
			this.panel3.TabIndex = 13;
			this.panel3.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(158, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Messages from employees:";
			// 
			// updateCompanyMsgButton
			// 
			this.updateCompanyMsgButton.Location = new System.Drawing.Point(358, 171);
			this.updateCompanyMsgButton.Margin = new System.Windows.Forms.Padding(2);
			this.updateCompanyMsgButton.Name = "updateCompanyMsgButton";
			this.updateCompanyMsgButton.Size = new System.Drawing.Size(59, 20);
			this.updateCompanyMsgButton.TabIndex = 5;
			this.updateCompanyMsgButton.Text = "send";
			this.updateCompanyMsgButton.UseVisualStyleBackColor = true;
			this.updateCompanyMsgButton.Click += new System.EventHandler(this.updateCompanyMessageButton_Click);
			// 
			// companyMsgBox
			// 
			this.companyMsgBox.Location = new System.Drawing.Point(159, 145);
			this.companyMsgBox.Margin = new System.Windows.Forms.Padding(2);
			this.companyMsgBox.Name = "companyMsgBox";
			this.companyMsgBox.Size = new System.Drawing.Size(261, 20);
			this.companyMsgBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 148);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Update company message:";
			// 
			// adminSignOutButton
			// 
			this.adminSignOutButton.Location = new System.Drawing.Point(8, 67);
			this.adminSignOutButton.Margin = new System.Windows.Forms.Padding(2);
			this.adminSignOutButton.Name = "adminSignOutButton";
			this.adminSignOutButton.Size = new System.Drawing.Size(106, 24);
			this.adminSignOutButton.TabIndex = 2;
			this.adminSignOutButton.Text = "Sign out";
			this.adminSignOutButton.UseVisualStyleBackColor = true;
			this.adminSignOutButton.Click += new System.EventHandler(this.adminSignOutButton_Click);
			// 
			// showAdminMsgsButton
			// 
			this.showAdminMsgsButton.Location = new System.Drawing.Point(8, 10);
			this.showAdminMsgsButton.Margin = new System.Windows.Forms.Padding(2);
			this.showAdminMsgsButton.Name = "showAdminMsgsButton";
			this.showAdminMsgsButton.Size = new System.Drawing.Size(106, 32);
			this.showAdminMsgsButton.TabIndex = 1;
			this.showAdminMsgsButton.Text = "Show Messages";
			this.showAdminMsgsButton.UseVisualStyleBackColor = true;
			this.showAdminMsgsButton.Click += new System.EventHandler(this.showMsgsButton_Click);
			// 
			// adminMsgsListBox
			// 
			this.adminMsgsListBox.FormattingEnabled = true;
			this.adminMsgsListBox.Location = new System.Drawing.Point(159, 28);
			this.adminMsgsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.adminMsgsListBox.Name = "adminMsgsListBox";
			this.adminMsgsListBox.Size = new System.Drawing.Size(261, 69);
			this.adminMsgsListBox.TabIndex = 0;
			this.adminMsgsListBox.DoubleClick += new System.EventHandler(this.adminMsgsListBox_DoubleClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// accountToolStripMenuItem
			// 
			this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
			this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
			this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.accountToolStripMenuItem.Text = "Account";
			// 
			// signOutToolStripMenuItem
			// 
			this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
			this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.signOutToolStripMenuItem.Text = "Sign Out";
			this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
			// 
			// UserPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 591);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UserPanel";
			this.Text = "Feedback Program";
			this.Load += new System.EventHandler(this.UserPanel_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label accountInfoLabel;
        private System.Windows.Forms.Label enterMsgLabel;
        private System.Windows.Forms.CheckBox anonymousCheckBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
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
		private System.Windows.Forms.RichTextBox feedbackBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
	}
}

