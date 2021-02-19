using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_For_Login
{
    public partial class Form2 : Form
    {
        private FeedbackMessage message;
        private SmtpClient smtpClient;


        public Form2(FeedbackMessage msg)
        {
            InitializeComponent();
            message = msg;
            if (!message.anonymous)
            {
                msgInfoLabel.Text = $"{message.message}\nMessage created by {message.email}.\nCreated {message.dateCreated}";
            }
            else
            {
                msgInfoLabel.Text = $"{message.message}\nMessage created anonymously.\nCreated {message.dateCreated}";
            }
            
        }

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emailBox.Visible = true;
            emailLabel.Visible = true;
            sendEmailButton.Visible = true;
            nameLabel.Visible = true;
            nameBox.Visible = true;
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            // Set email client only if an email will be sent.
            smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("cis340capstoneteam@gmail.com", "capston3!"),
                EnableSsl = true,
            };
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("cis340capstoneteam@gmail.com"),
                Subject = "Message sent",
                IsBodyHtml = true,
                Body = $"<body>{nameBox.Text} replying to your message sent on {message.dateCreated}<br>" +
                $"Your message: {message.message} <br>Their message: {emailBox.Text}</body>"
            };
            mailMessage.To.Add(message.email);
            smtpClient.Send(mailMessage);
            if (!message.anonymous)
            {
                MessageBox.Show($"Email sent to {message.email}");
            }
            else
            {
                MessageBox.Show("Email sent to anonymous user");
            }
            
            emailBox.Text = "";
            nameBox.Text = "";
            emailBox.Visible = false;
            nameBox.Visible = false;
            emailLabel.Visible = false;
            nameLabel.Visible = false;
            sendEmailButton.Visible = false;

        }

		private void nameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void emailBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void emailLabel_Click(object sender, EventArgs e)
		{

		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
