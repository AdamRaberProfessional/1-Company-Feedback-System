using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Mail;
using System.Net;


// Search for #QUERY for an example of querying the database and #WRITE for an example of writing to the database.

namespace Test_For_Login
{
	public partial class UserPanel : Form
	{
		// Initialize firebase auth and create ability to get the current firebaseUser anywhere in the application.
		private readonly FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
		private readonly FirebaseClient databaseHandler = new FirebaseClient("https://cis-attempt-1-default-rtdb.firebaseio.com/");
		private SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
		{
			Port = 587,
			Credentials = new NetworkCredential("cis340capstoneteam@gmail.com", "capston3!"),
			EnableSsl = true,
		};


		private AccountInfo accountData;
		private string pageState = "signIn";
		private bool exitApplication = true;
		private string feedbackText;
		private FeedbackMessage adminChosenMsg;
		List<FeedbackMessage> msgList;
		List<FeedbackMessage> userMsgList;

		public Firebase.Auth.User firebaseUser { get; set; }
		

		private async Task UpdateMessageListAsync()
		{
			msgList =  await databaseHandler.Child("Messages").OnceSingleAsync<List<FeedbackMessage>>();
			if(msgList == null)
            {
				msgList = new List<FeedbackMessage>();
            }
		}

		private async void AddMessage()
        {
			// #QUERY
			await UpdateMessageListAsync();
			// #WRITE
			if (anonymousCheckBox.Checked == false)
			{ 
				// create Message with email address, add to messages, upload to firebase
				FeedbackMessage tempMsg = new FeedbackMessage(feedbackBox.Text, DateTime.Now.ToString(), firebaseUser.Email, false); // Message that stores email
				if(msgList != null)
                {
					msgList.Add(tempMsg);
				}
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}
            else 
			{
				// create Message without email address, add to messages, and upload to firebase.
				FeedbackMessage tempMsg = new FeedbackMessage(feedbackBox.Text, DateTime.Now.ToString(), firebaseUser.Email, true);
				if (msgList != null)
				{
					msgList.Add(tempMsg);
                }
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}

			MailMessage mailMessage = new MailMessage
			{
				From = new MailAddress("cis340capstoneteam@gmail.com"),
				Subject = "Message sent",
				IsBodyHtml = true,
			};

            if (anonymousCheckBox.Checked)
            {
				mailMessage.Body = "<body>Thank you for your input to the company! We can assure you your input was anonymous. Here is the message that you sent: <br>" +
				$"{feedbackBox.Text} <br> Sent {DateTime.Now.ToString()}</body>";
            }
            else
            {
				mailMessage.Body = "<body>Thank you for your input to the company! You chose to send it non-anonymously. Here is the message that you sent: <br>" +
				$"{feedbackBox.Text} <br> Sent {DateTime.Now.ToString()}</body>";
			}
			mailMessage.To.Add(firebaseUser.Email);
			feedbackBox.Text = "";
			userShowMsgs();
			if (anonymousCheckBox.Checked == false)
			{
				MessageBox.Show("Message sent");
			}
			else if (anonymousCheckBox.Checked == true)
			{
				MessageBox.Show("Anyonymous message sent");
			}
			

			smtpClient.Send(mailMessage);
			anonymousCheckBox.Checked = false;

			
		}

		private void SignUserOut()
        {
			firebaseUser = null;
			accountData = null;
			adminMsgsListBox.Items.Clear();
			userMsgsListBox.Items.Clear();
			userMsgList = null;
			exitApplication = false;
			this.Close();
			LoginPanel Login = new LoginPanel();
			Login.Show();
		}

		private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (exitApplication)
			{
				Application.Exit();
			}
			
		}

		public UserPanel()
		{
			InitializeComponent();
		}

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
			if(sendMsgButton.Text == "Create New Feedback")
			{
				feedbackBox.Text = feedbackText;
				feedbackBox.Enabled = true;
				sendMsgButton.Text = "Send Feedback";
				anonymousCheckBox.Visible = true;
				enterMsgLabel.Text = $"Enter feedback message here:";
			}
			else if (sendMsgButton.Text == "Send Feedback")
			{
				AddMessage();
			}
		}

        private void adminSignOutButton_Click(object sender, EventArgs e)
        {
			SignUserOut();
        }


		private async void showMessages()
		{
			await UpdateMessageListAsync();
			if (InvokeRequired)
			{
				this.Invoke(new MethodInvoker(delegate
				{
					adminMsgsListBox.Items.Clear();
					if (msgList != null)
					{
						foreach (FeedbackMessage msg in msgList)
						{
							string feedbackDate = DateTime.Parse(msg.dateCreated).ToString("MMMM dd,  h:mm tt");

							string email = msg.email;
							if (msg.anonymous)
							{
								email = "anonymous";
							}
						
							
							adminMsgsListBox.Items.Add($"{feedbackDate} ( {email} )");
						}
					}
					else if (msgList == null)
					{
						MessageBox.Show("No messages to show");
					}
				}));
			}
			
			
		}


		private void adminMsgsListBox_DoubleClick(object sender, EventArgs e)
		{
			FeedbackMessage chosenMsg = msgList[adminMsgsListBox.SelectedIndex];
			Form2 form2 = new Form2(chosenMsg);
			form2.ShowDialog();
		}

		private void adminMsgsListBox_Click(object sender, EventArgs e)
		{
			try
			{
				adminChosenMsg = msgList[adminMsgsListBox.SelectedIndex];
				this.Size = new Size(859, 367);
				adminFeedbackBox.Visible = true;
				replyButton.Visible = true;
				adminFeedbackBox.Text = adminChosenMsg.message;

				adminFeedbackLabel.Visible = true;
				
				if (!adminChosenMsg.anonymous)
				{
					adminFeedbackLabel.Text = $"Feedback from {adminChosenMsg.email} on {adminChosenMsg.dateCreated}";
				}
				else
				{
					adminFeedbackLabel.Text = $"Feedback from anonymous user on {adminChosenMsg.dateCreated}";
				}

			}
			catch
			{
				return;
			}
		}




		private async void userShowMsgs()
		{
			// Create a list of Messages that were sent from the user's email and show it in the list box.
			String currentUserEmail = firebaseUser.Email;
			userMsgsListBox.Items.Clear();
			await UpdateMessageListAsync();
			userMsgList = new List<FeedbackMessage>(); // added to avoid object being null.
			DateTime newestFeedback = DateTime.Now.AddDays(-10000);
			DateTime currentFeedback;

			foreach (FeedbackMessage msg in msgList)
			{
				Console.WriteLine($"{msg.email}: {currentUserEmail}");
				if (msg.email == currentUserEmail)
				{
					currentFeedback = DateTime.Parse(msg.dateCreated);
					string feedbackDate = currentFeedback.ToString("MMMM dd,  h:mm tt");

					userMsgsListBox.Items.Add(feedbackDate);
					userMsgList.Add(msg);
					
					if(currentFeedback > newestFeedback)
					{
						newestFeedback = currentFeedback;
					}
				}
			}
			if(newestFeedback > DateTime.Now.AddDays(-7))
			{
				string eligible = newestFeedback.AddDays(7).ToString("MMMM dd, h:mm tt");

				eligibleLabel.Visible = true;
				anonymousCheckBox.Visible = false;
				feedbackBox.Enabled = false;
				sendMsgButton.Visible = false;

				eligibleLabel.Text = $"You have sent feedback in the last 7 days and cannot send anymore until {eligible}";			
				enterMsgLabel.Text =  "";
				
			}

		}


		private void userMsgListBox_Click(object sender, EventArgs e)
		{
			
			try
			{
				FeedbackMessage chosenMsg = userMsgList[userMsgsListBox.SelectedIndex];
				feedbackBox.Text = chosenMsg.message;
				feedbackBox.Enabled = false;
				sendMsgButton.Text = "Create New Feedback";
				anonymousCheckBox.Visible = false;

				if (!chosenMsg.anonymous)
				{
					enterMsgLabel.Text = $"Your feedback from {userMsgsListBox.SelectedItem}";
				}
				else
				{
					enterMsgLabel.Text = $"Your anonymous feedback from {userMsgsListBox.SelectedItem}";
				}
			}
			catch
			{
				return;
			}

		}

		private async void updateCompanyMessageButton_Click(object sender, EventArgs e)
        {
			List<CompanyMessage> messages = await databaseHandler.Child("adminMessages").OnceSingleAsync<List<CompanyMessage>>();
			CompanyMessage newMessage = new CompanyMessage(companyMsgBox.Text, DateTime.Now.ToString(), firebaseUser.Email);
			if (messages != null)
            {
				messages.Add(newMessage);
            }
            else
            {
				messages = new List<CompanyMessage>();
				messages.Add(newMessage);
            }
			await databaseHandler.Child("adminMessages").PutAsync(messages);
			MessageBox.Show("Company Message Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
			companyMsgBox.Text = "";
		}

		private async void UserPanel_Load(object sender, EventArgs e)
		{
			accountData = await databaseHandler.Child("accounts").Child(firebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();
			
			feedbackText = feedbackBox.Text;
			this.FormClosing += UserPanel_FormClosing;
			
			if (accountData.accountType == "User")
			{
				this.Size = new Size(723, 317);
				panel2.Visible = true;
				panel2.Location = new Point(11, 26);
				accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}";
				userShowMsgs();
			}else if(accountData.accountType == "Admin")
			{		
				this.Size = new Size(319, 362);
				panel3.Visible = true;
				panel3.Location = new Point(11, 26);
				adminSignedInLabel.Text = $"Signed in as Admin with {firebaseUser.Email}";
				bgw_msgList.RunWorkerAsync();	
			}
		}

		private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SignUserOut();
		}

		private void bgw_msgList_DoWork(object sender, DoWorkEventArgs e)
		{
			showMessages();
		}

		private void replyButton_Click(object sender, EventArgs e)
		{
			this.Size = new Size(859, 556);
			nameBox.Visible = true;
			emailBox.Visible = true;
			sendEmailButton.Visible = true;
		}

		private void emailBox_Click(object sender, EventArgs e)
		{
			if(emailBox.Text == "Enter your reply here")
			{
				emailBox.Text = "";
			}
		}

		private void nameBox_Click(object sender, EventArgs e)
		{
			if (nameBox.Text == "Enter your name here")
			{
				nameBox.Text = "";
			}
		}

		private void sendEmailButton_Click(object sender, EventArgs e)
		{
			if (nameBox.Text == "Enter your name here" || String.IsNullOrWhiteSpace(nameBox.Text))
			{
				MessageBox.Show("Please enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (emailBox.Text == "Enter your reply here" || String.IsNullOrWhiteSpace(emailBox.Text))
			{
				MessageBox.Show("Cannot send blank or unedited email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;		
			}
			
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
				Body = $"<body>{nameBox.Text} replying to your message sent on {adminChosenMsg.dateCreated}<br>" +
				$"Your message: {adminChosenMsg.message} <br>Their message: {emailBox.Text}</body>"
			};

			nameBox.Text = "Enter your name here";
			nameBox.Visible = false;

			emailBox.Text = "Enter your reply here";
			emailBox.Visible = false;

			sendEmailButton.Visible = false;
			this.Size = new Size(859, 367);
			mailMessage.To.Add(adminChosenMsg.email);
			smtpClient.Send(mailMessage);
			if (!adminChosenMsg.anonymous)
			{
				MessageBox.Show($"Email sent to {adminChosenMsg.email}");
			}
			else
			{
				MessageBox.Show("Email sent to anonymous user");
			}

		}
	}
}
