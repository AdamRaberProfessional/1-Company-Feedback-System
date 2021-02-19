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
			this.userFeedbackHistoryLabel = new System.Windows.Forms.Label();
			this.userMsgsListBox = new System.Windows.Forms.ListBox();
			this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
			this.sendMsgButton = new System.Windows.Forms.Button();
			this.enterMsgLabel = new System.Windows.Forms.Label();
			this.accountInfoLabel = new System.Windows.Forms.Label();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel3 = new System.Windows.Forms.Panel();
			this.sendEmailButton = new System.Windows.Forms.Button();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.emailBox = new System.Windows.Forms.RichTextBox();
			this.replyButton = new System.Windows.Forms.Button();
			this.adminSignedInLabel = new System.Windows.Forms.Label();
			this.adminFeedbackLabel = new System.Windows.Forms.Label();
			this.adminFeedbackHistoryLabel = new System.Windows.Forms.Label();
			this.adminFeedbackBox = new System.Windows.Forms.RichTextBox();
			this.updateCompanyMsgButton = new System.Windows.Forms.Button();
			this.companyMsgBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.adminMsgsListBox = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bgw_msgList = new System.ComponentModel.BackgroundWorker();
			this.eligibleLabel = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.eligibleLabel);
			this.panel2.Controls.Add(this.feedbackBox);
			this.panel2.Controls.Add(this.userFeedbackHistoryLabel);
			this.panel2.Controls.Add(this.userMsgsListBox);
			this.panel2.Controls.Add(this.anonymousCheckBox);
			this.panel2.Controls.Add(this.sendMsgButton);
			this.panel2.Controls.Add(this.enterMsgLabel);
			this.panel2.Controls.Add(this.accountInfoLabel);
			this.panel2.Location = new System.Drawing.Point(11, 530);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(679, 236);
			this.panel2.TabIndex = 12;
			this.panel2.Visible = false;
			// 
			// feedbackBox
			// 
			this.feedbackBox.Location = new System.Drawing.Point(260, 59);
			this.feedbackBox.Name = "feedbackBox";
			this.feedbackBox.Size = new System.Drawing.Size(394, 118);
			this.feedbackBox.TabIndex = 10;
			this.feedbackBox.Text = "What\'s one thing you like about working here?\n\n\nWhats one thing we can improve, a" +
    "nd how can we improve it?\n\n\nAny other suggestions?";
			// 
			// userFeedbackHistoryLabel
			// 
			this.userFeedbackHistoryLabel.AutoSize = true;
			this.userFeedbackHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userFeedbackHistoryLabel.Location = new System.Drawing.Point(7, 36);
			this.userFeedbackHistoryLabel.Name = "userFeedbackHistoryLabel";
			this.userFeedbackHistoryLabel.Size = new System.Drawing.Size(133, 20);
			this.userFeedbackHistoryLabel.TabIndex = 9;
			this.userFeedbackHistoryLabel.Text = "Feedback History";
			// 
			// userMsgsListBox
			// 
			this.userMsgsListBox.FormattingEnabled = true;
			this.userMsgsListBox.Location = new System.Drawing.Point(11, 60);
			this.userMsgsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.userMsgsListBox.Name = "userMsgsListBox";
			this.userMsgsListBox.Size = new System.Drawing.Size(191, 95);
			this.userMsgsListBox.TabIndex = 7;
			this.userMsgsListBox.Click += new System.EventHandler(this.userMsgListBox_Click);
			// 
			// anonymousCheckBox
			// 
			this.anonymousCheckBox.AutoSize = true;
			this.anonymousCheckBox.Location = new System.Drawing.Point(261, 189);
			this.anonymousCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.anonymousCheckBox.Name = "anonymousCheckBox";
			this.anonymousCheckBox.Size = new System.Drawing.Size(158, 17);
			this.anonymousCheckBox.TabIndex = 5;
			this.anonymousCheckBox.Text = "Make feedback anonymous";
			this.anonymousCheckBox.UseVisualStyleBackColor = true;
			// 
			// sendMsgButton
			// 
			this.sendMsgButton.Location = new System.Drawing.Point(532, 182);
			this.sendMsgButton.Margin = new System.Windows.Forms.Padding(2);
			this.sendMsgButton.Name = "sendMsgButton";
			this.sendMsgButton.Size = new System.Drawing.Size(122, 28);
			this.sendMsgButton.TabIndex = 4;
			this.sendMsgButton.Text = "Send Feedback";
			this.sendMsgButton.UseVisualStyleBackColor = true;
			this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
			// 
			// enterMsgLabel
			// 
			this.enterMsgLabel.AutoSize = true;
			this.enterMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterMsgLabel.Location = new System.Drawing.Point(257, 36);
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
			this.panel3.Controls.Add(this.sendEmailButton);
			this.panel3.Controls.Add(this.nameBox);
			this.panel3.Controls.Add(this.emailBox);
			this.panel3.Controls.Add(this.replyButton);
			this.panel3.Controls.Add(this.adminSignedInLabel);
			this.panel3.Controls.Add(this.adminFeedbackLabel);
			this.panel3.Controls.Add(this.adminFeedbackHistoryLabel);
			this.panel3.Controls.Add(this.adminFeedbackBox);
			this.panel3.Controls.Add(this.updateCompanyMsgButton);
			this.panel3.Controls.Add(this.companyMsgBox);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.adminMsgsListBox);
			this.panel3.Location = new System.Drawing.Point(11, 41);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(818, 471);
			this.panel3.TabIndex = 13;
			this.panel3.Visible = false;
			// 
			// sendEmailButton
			// 
			this.sendEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sendEmailButton.Location = new System.Drawing.Point(544, 424);
			this.sendEmailButton.Margin = new System.Windows.Forms.Padding(2);
			this.sendEmailButton.Name = "sendEmailButton";
			this.sendEmailButton.Size = new System.Drawing.Size(157, 29);
			this.sendEmailButton.TabIndex = 20;
			this.sendEmailButton.Text = "Send";
			this.sendEmailButton.UseVisualStyleBackColor = true;
			this.sendEmailButton.Visible = false;
			this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(307, 272);
			this.nameBox.Margin = new System.Windows.Forms.Padding(1);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(236, 20);
			this.nameBox.TabIndex = 17;
			this.nameBox.Text = "Enter your name here";
			this.nameBox.Visible = false;
			this.nameBox.Click += new System.EventHandler(this.nameBox_Click);
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(307, 303);
			this.emailBox.Margin = new System.Windows.Forms.Padding(1);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(394, 116);
			this.emailBox.TabIndex = 16;
			this.emailBox.Text = "Enter your reply here";
			this.emailBox.Visible = false;
			this.emailBox.Click += new System.EventHandler(this.emailBox_Click);
			// 
			// replyButton
			// 
			this.replyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.replyButton.Location = new System.Drawing.Point(544, 191);
			this.replyButton.Margin = new System.Windows.Forms.Padding(2);
			this.replyButton.Name = "replyButton";
			this.replyButton.Size = new System.Drawing.Size(157, 29);
			this.replyButton.TabIndex = 15;
			this.replyButton.Text = "Reply to feedback";
			this.replyButton.UseVisualStyleBackColor = true;
			this.replyButton.Visible = false;
			this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
			// 
			// adminSignedInLabel
			// 
			this.adminSignedInLabel.AutoSize = true;
			this.adminSignedInLabel.Location = new System.Drawing.Point(8, 8);
			this.adminSignedInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.adminSignedInLabel.Name = "adminSignedInLabel";
			this.adminSignedInLabel.Size = new System.Drawing.Size(89, 13);
			this.adminSignedInLabel.TabIndex = 14;
			this.adminSignedInLabel.Text = "No user signed in";
			// 
			// adminFeedbackLabel
			// 
			this.adminFeedbackLabel.AutoSize = true;
			this.adminFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminFeedbackLabel.Location = new System.Drawing.Point(303, 32);
			this.adminFeedbackLabel.Name = "adminFeedbackLabel";
			this.adminFeedbackLabel.Size = new System.Drawing.Size(133, 20);
			this.adminFeedbackLabel.TabIndex = 13;
			this.adminFeedbackLabel.Text = "Feedback History";
			this.adminFeedbackLabel.Visible = false;
			// 
			// adminFeedbackHistoryLabel
			// 
			this.adminFeedbackHistoryLabel.AutoSize = true;
			this.adminFeedbackHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminFeedbackHistoryLabel.Location = new System.Drawing.Point(7, 32);
			this.adminFeedbackHistoryLabel.Name = "adminFeedbackHistoryLabel";
			this.adminFeedbackHistoryLabel.Size = new System.Drawing.Size(133, 20);
			this.adminFeedbackHistoryLabel.TabIndex = 12;
			this.adminFeedbackHistoryLabel.Text = "Feedback History";
			// 
			// adminFeedbackBox
			// 
			this.adminFeedbackBox.Location = new System.Drawing.Point(307, 59);
			this.adminFeedbackBox.Name = "adminFeedbackBox";
			this.adminFeedbackBox.ReadOnly = true;
			this.adminFeedbackBox.Size = new System.Drawing.Size(394, 118);
			this.adminFeedbackBox.TabIndex = 11;
			this.adminFeedbackBox.Text = "";
			this.adminFeedbackBox.Visible = false;
			// 
			// updateCompanyMsgButton
			// 
			this.updateCompanyMsgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateCompanyMsgButton.Location = new System.Drawing.Point(183, 242);
			this.updateCompanyMsgButton.Margin = new System.Windows.Forms.Padding(2);
			this.updateCompanyMsgButton.Name = "updateCompanyMsgButton";
			this.updateCompanyMsgButton.Size = new System.Drawing.Size(92, 29);
			this.updateCompanyMsgButton.TabIndex = 5;
			this.updateCompanyMsgButton.Text = "send";
			this.updateCompanyMsgButton.UseVisualStyleBackColor = true;
			this.updateCompanyMsgButton.Click += new System.EventHandler(this.updateCompanyMessageButton_Click);
			// 
			// companyMsgBox
			// 
			this.companyMsgBox.Location = new System.Drawing.Point(11, 218);
			this.companyMsgBox.Margin = new System.Windows.Forms.Padding(2);
			this.companyMsgBox.Name = "companyMsgBox";
			this.companyMsgBox.Size = new System.Drawing.Size(264, 20);
			this.companyMsgBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 191);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Update company message:";
			// 
			// adminMsgsListBox
			// 
			this.adminMsgsListBox.FormattingEnabled = true;
			this.adminMsgsListBox.Location = new System.Drawing.Point(9, 59);
			this.adminMsgsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.adminMsgsListBox.Name = "adminMsgsListBox";
			this.adminMsgsListBox.Size = new System.Drawing.Size(266, 108);
			this.adminMsgsListBox.TabIndex = 0;
			this.adminMsgsListBox.Click += new System.EventHandler(this.adminMsgsListBox_Click);
			this.adminMsgsListBox.DoubleClick += new System.EventHandler(this.adminMsgsListBox_DoubleClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
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
			this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.signOutToolStripMenuItem.Text = "Sign Out";
			this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
			// 
			// bgw_msgList
			// 
			this.bgw_msgList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_msgList_DoWork);
			// 
			// eligibleLabel
			// 
			this.eligibleLabel.AutoSize = true;
			this.eligibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eligibleLabel.Location = new System.Drawing.Point(6, 219);
			this.eligibleLabel.Name = "eligibleLabel";
			this.eligibleLabel.Size = new System.Drawing.Size(90, 13);
			this.eligibleLabel.TabIndex = 11;
			this.eligibleLabel.Text = "Feedback History";
			this.eligibleLabel.Visible = false;
			// 
			// UserPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 774);
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
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button updateCompanyMsgButton;
		private System.Windows.Forms.TextBox companyMsgBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox adminMsgsListBox;
		private System.Windows.Forms.RichTextBox feedbackBox;
		private System.Windows.Forms.Label userFeedbackHistoryLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
		private System.Windows.Forms.RichTextBox adminFeedbackBox;
		private System.ComponentModel.BackgroundWorker bgw_msgList;
		private System.Windows.Forms.Label adminFeedbackHistoryLabel;
		private System.Windows.Forms.Label adminFeedbackLabel;
		private System.Windows.Forms.Label adminSignedInLabel;
		private System.Windows.Forms.Button replyButton;
		private System.Windows.Forms.Button sendEmailButton;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.RichTextBox emailBox;
		private System.Windows.Forms.Label eligibleLabel;
	}
}

