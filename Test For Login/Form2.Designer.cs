
namespace Test_For_Login
{
    partial class Form2
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
			this.msgInfoLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.emailBox = new System.Windows.Forms.RichTextBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.sendEmailButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// msgInfoLabel
			// 
			this.msgInfoLabel.AutoSize = true;
			this.msgInfoLabel.Location = new System.Drawing.Point(29, 18);
			this.msgInfoLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.msgInfoLabel.Name = "msgInfoLabel";
			this.msgInfoLabel.Size = new System.Drawing.Size(131, 13);
			this.msgInfoLabel.TabIndex = 0;
			this.msgInfoLabel.Text = "No message info available";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 82);
			this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Send email to message creator";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(335, 105);
			this.emailBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(236, 98);
			this.emailBox.TabIndex = 3;
			this.emailBox.Text = "";
			this.emailBox.Visible = false;
			this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(335, 75);
			this.nameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(236, 20);
			this.nameBox.TabIndex = 4;
			this.nameBox.Visible = false;
			this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(264, 78);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(60, 13);
			this.nameLabel.TabIndex = 5;
			this.nameLabel.Text = "Your Name";
			this.nameLabel.Visible = false;
			this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(250, 107);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(72, 13);
			this.emailLabel.TabIndex = 6;
			this.emailLabel.Text = "Email Content";
			this.emailLabel.Visible = false;
			this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
			// 
			// sendEmailButton
			// 
			this.sendEmailButton.Location = new System.Drawing.Point(498, 214);
			this.sendEmailButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.sendEmailButton.Name = "sendEmailButton";
			this.sendEmailButton.Size = new System.Drawing.Size(70, 23);
			this.sendEmailButton.TabIndex = 7;
			this.sendEmailButton.Text = "Send";
			this.sendEmailButton.UseVisualStyleBackColor = true;
			this.sendEmailButton.Visible = false;
			this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 307);
			this.Controls.Add(this.sendEmailButton);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.emailBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.msgInfoLabel);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgInfoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button sendEmailButton;
    }
}