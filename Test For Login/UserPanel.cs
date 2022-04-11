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
using System.Net.Mail;
using System.Net;



namespace Test_For_Login
{
	public partial class UserPanel : Form
	{
		// Initialize firebase auth and create ability to get the current firebaseUser anywhere in the application.
		private readonly FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyDwSFECwPpPmv8e9c9ycFio6LV6ulLa_fs"));
		private readonly FirebaseClient databaseHandler = new FirebaseClient("https://dotnet-project-3f3cf-default-rtdb.firebaseio.com/");
		private readonly SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
		{
			Port = 587,
			Credentials = new NetworkCredential("cis340adam@gmail.com", "plsdon'thack"),
			EnableSsl = true,
		};

		private bool exitApplication = true;
		private string feedbackText;
		private FeedbackMessage adminChosenMsg;
		private List<FeedbackMessage> msgList;
		private List<FeedbackMessage> userSpecificMsgList;

		public Firebase.Auth.User FirebaseUser { get; set; }

		public UserPanel()
		{
			InitializeComponent();
		}

		private async Task UpdateMessageListAsync()
		{
			msgList =  await databaseHandler.Child("Messages").OnceSingleAsync<List<FeedbackMessage>>();
			if(msgList == null)
            {
				msgList = new List<FeedbackMessage>();
            }
		}

		private async void AddMessageAsync()
        {
			await UpdateMessageListAsync();
			
			if (anonymousCheckBox.Checked == false)
			{ 
				// create Message with email address, add to messages, upload to firebase
				FeedbackMessage tempMsg = new FeedbackMessage(feedbackBox.Text, DateTime.Now.ToString(), FirebaseUser.Email, false); // Message that stores email
				if(msgList != null)
                {
					msgList.Add(tempMsg);
				}
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}
            else 
			{
				// create Message without email address, add to messages, and upload to firebase.
				FeedbackMessage tempMsg = new FeedbackMessage(feedbackBox.Text, DateTime.Now.ToString(), FirebaseUser.Email, true);
				if (msgList != null)
				{
					msgList.Add(tempMsg);
                }
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}
			/*
			MailMessage mailMessage = new MailMessage
			{
				From = new MailAddress("cis340adam@gmail.com"),
				Subject = "Thank you for your feedback!",
				IsBodyHtml = false,
			};

            if (anonymousCheckBox.Checked)
            {
				mailMessage.Body = "Thank you for your input to the company! We can assure you your input was anonymous. Here is the message that you sent:\n\n" +
				$"{feedbackBox.Text} \n\nFeedback sent {DateTime.Now.ToString()}";
            }
            else
            {
				mailMessage.Body = "Thank you for your input to the company! You chose to send it non-anonymously. Here is the message that you sent: \n\n" +
				$"{feedbackBox.Text} \n\nFeedback sent {DateTime.Now.ToString()}";
			}*/

			feedbackBox.Text = "What's one thing you like about working here?\n\n\nWhats one thing we can improve, and how can we improve it?\n\n\nAny other suggestions?";
			ShowUserFeedbackAsync();
			if (anonymousCheckBox.Checked == false)
			{
				MessageBox.Show("Feedback sent");
			}
			else if (anonymousCheckBox.Checked == true)
			{
				MessageBox.Show("Anyonymous feedback sent");
			}
			anonymousCheckBox.Checked = false;

			//mailMessage.To.Add(FirebaseUser.Email);

			//smtpClient.Send(mailMessage);		
		}

		private void SignUserOut()
        {
			FirebaseUser = null;
			adminMsgsListBox.Items.Clear();
			userMsgsListBox.Items.Clear();
			userSpecificMsgList = null;
			exitApplication = false;
			this.Close();
			LoginPanel Login = new LoginPanel();
			Login.Show();
		}

		private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
		{
			// close the application unless the user is being signed out
			if (exitApplication)
			{
				Application.Exit();
			}
			
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
				AddMessageAsync();
			}
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


		private async void ShowUserFeedbackAsync()
		{
			// Create a list of feedback that were sent from the user's email and show it in the list box.
			String currentUserEmail = FirebaseUser.Email;
			userMsgsListBox.Items.Clear();
			await UpdateMessageListAsync();
			userSpecificMsgList = new List<FeedbackMessage>(); // added to avoid object being null.
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
					userSpecificMsgList.Add(msg);
					
					if(currentFeedback > newestFeedback)
					{
						newestFeedback = currentFeedback;
					}
				}
			}
            if (!LoginPanel.devMode)
            {
				if (newestFeedback > DateTime.Now.AddDays(-7))
				{
					string eligible = newestFeedback.AddDays(7).ToString("MMMM dd, h:mm tt");

					eligibleLabel.Visible = true;
					anonymousCheckBox.Visible = false;
					feedbackBox.Enabled = false;
					sendMsgButton.Visible = false;

					eligibleLabel.Text = $"You have sent feedback in the last 7 days and cannot send anymore until {eligible}";
					enterMsgLabel.Text = "";

				}
			}
		}


		private void userMsgListBox_Click(object sender, EventArgs e)
		{
			
			try
			{
				FeedbackMessage chosenMsg = userSpecificMsgList[userMsgsListBox.SelectedIndex];
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
			CompanyMessage newMessage = new CompanyMessage(companyMsgBox.Text, DateTime.Now.ToString(), FirebaseUser.Email);
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
			companyMsgBox.Text = "";
			MessageBox.Show("Company Message Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private async void UserPanel_Load(object sender, EventArgs e)
		{
			AccountInfo accountData = await databaseHandler.Child("accounts").Child(FirebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();
			
			feedbackText = feedbackBox.Text;
			this.FormClosing += UserPanel_FormClosing;
			
			if (accountData.accountType == "User")
			{
				panel2.Visible = true;
				panel2.Location = new Point(11, 26);
				accountInfoLabel.Text = $"Signed in as {FirebaseUser.Email}";
				ShowUserFeedbackAsync();
			}else if(accountData.accountType == "Admin")
			{		
				panel3.Visible = true;
				panel3.Location = new Point(11, 26);
				adminSignedInLabel.Text = $"Signed in as Admin with {FirebaseUser.Email}";
				RenderAdminMsgs();
			}
		}

		private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SignUserOut();
		}

		private async void RenderAdminMsgs()
        {
			await UpdateMessageListAsync();

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

			MailMessage mailMessage = new MailMessage
			{

				From = new MailAddress("cis340adam@gmail.com"),
				Subject = "Message sent",
				IsBodyHtml = false,			
			};

            if (adminChosenMsg.anonymous)
            {
				mailMessage.Body = $"{nameBox.Text} is replying to your anonymous message sent on {adminChosenMsg.dateCreated}\n" +
				$"Your message: \n{adminChosenMsg.message} \n\nTheir message: {emailBox.Text}";

            }
            else
            {
				mailMessage.Body = $"{nameBox.Text} is replying to your message sent on {adminChosenMsg.dateCreated}\n" +
			   $"Your message: \n{adminChosenMsg.message} \n\nTheir message: {emailBox.Text}";

			}

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
