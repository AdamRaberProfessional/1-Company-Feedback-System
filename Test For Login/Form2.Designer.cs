
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
            this.msgInfoLabel.Location = new System.Drawing.Point(78, 43);
            this.msgInfoLabel.Name = "msgInfoLabel";
            this.msgInfoLabel.Size = new System.Drawing.Size(349, 32);
            this.msgInfoLabel.TabIndex = 0;
            this.msgInfoLabel.Text = "No message info available";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send email to message creator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(893, 251);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(624, 229);
            this.emailBox.TabIndex = 3;
            this.emailBox.Text = "";
            this.emailBox.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(893, 180);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(624, 38);
            this.nameBox.TabIndex = 4;
            this.nameBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(705, 186);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 32);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Your Name";
            this.nameLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(668, 254);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(194, 32);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email Content";
            this.emailLabel.Visible = false;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(1329, 511);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(188, 55);
            this.sendEmailButton.TabIndex = 7;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Visible = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 732);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgInfoLabel);
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