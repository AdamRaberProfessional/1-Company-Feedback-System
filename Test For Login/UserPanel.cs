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
		List<FeedbackMessage> msgList;
		List<FeedbackMessage> userMsgList;

		public Firebase.Auth.User firebaseUser { get; set; }
		
		/*private void ChangePanel(int panelNumber)
        {
			// Change the panel according to the panelNumber given. 
			if(panelNumber == 1)
            {
				//panel1.Visible = true;
				panel2.Visible = false;
				panel3.Visible = false;
			}
			else if(panelNumber == 2)
            {
				//panel1.Visible = false;
				panel2.Visible = true;
				panel3.Visible = false;
            }else if (panelNumber == 3)
            {
				//panel1.Visible = false;
				panel2.Visible = false;
				panel3.Visible = true;
            }
        }*/

		

		/*private async void UserSignedInAsync()
        {
			// Set accountData to match the data from the signed in user.
			// #QUERY
			accountData = await databaseHandler.Child("accounts").Child(firebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();
			if(accountData.accountType == "User")
            {
				List<CompanyMessage> messages = await databaseHandler.Child("adminMessages").OnceSingleAsync<List<CompanyMessage>>();
				adminMessageLabel.Text = messages[messages.Count() - 1].message;
				ChangePanel(2);
			}
			else if (accountData.accountType == "Admin")
            {
				ChangePanel(3);
            }

				accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}. Account type is {accountData.accountType}";
        }*/


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
			smtpClient.Send(mailMessage);

			
			anonymousCheckBox.Checked = false;

			if (anonymousCheckBox.Checked == false)
			{
				MessageBox.Show("Message sent");
			}
			else if (anonymousCheckBox.Checked == true)
			{
				MessageBox.Show("Anyonymous message sent");
			}
			userShowMsgs();
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

        private async void showMsgsButton_Click(object sender, EventArgs e)
        {
			await UpdateMessageListAsync();
			adminMsgsListBox.Items.Clear();
			if(msgList != null)
            {
				foreach (FeedbackMessage msg in msgList)
				{
					adminMsgsListBox.Items.Add(msg.message);
				}
            }
            else if(msgList == null)
            {
				MessageBox.Show("No messages to show");
            }
		}

		private void adminMsgsListBox_DoubleClick(object sender, EventArgs e)
		{
			FeedbackMessage chosenMsg = msgList[adminMsgsListBox.SelectedIndex];
			Form2 form2 = new Form2(chosenMsg);
			form2.ShowDialog();
		}

   

		private async void userShowMsgs()
		{
			// Create a list of Messages that were sent from the user's email and show it in the list box.
			String currentUserEmail = firebaseUser.Email;
			userMsgsListBox.Items.Clear();
			await UpdateMessageListAsync();
			userMsgList = new List<FeedbackMessage>(); // added to avoid object being null.
			foreach (FeedbackMessage msg in msgList)
			{
				Console.WriteLine($"{msg.email}: {currentUserEmail}");
				if (msg.email == currentUserEmail)
				{

					DateTime feedbackDate = DateTime.Parse(msg.dateCreated);

					userMsgsListBox.Items.Add(feedbackDate.ToString("MMMM dd,  h:mm tt"));
					userMsgList.Add(msg);
				}
			}
		}


		private void userMsgListBox_Click(object sender, EventArgs e)
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
		}

		private async void UserPanel_Load(object sender, EventArgs e)
		{
			accountData = await databaseHandler.Child("accounts").Child(firebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();
			accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}";
			feedbackText = feedbackBox.Text;
			this.FormClosing += UserPanel_FormClosing;
			if (accountData.accountType == "User")
			{
				panel2.Visible = true;
				userShowMsgs();
			}else if(accountData.accountType == "Admin")
			{
				panel3.Visible = true;
			}
		}

		private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SignUserOut();
		}

		
	}
}
