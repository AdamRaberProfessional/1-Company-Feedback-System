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
	public partial class Form1 : Form
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
		List<Message> msgList;
		List<Message> userMsgList;

		private Firebase.Auth.User firebaseUser;

		private void ChangePanel(int panelNumber)
        {
			// Change the panel according to the panelNumber given. 
			if(panelNumber == 1)
            {
				panel1.Visible = true;
				panel2.Visible = false;
				panel3.Visible = false;
			}
			else if(panelNumber == 2)
            {
				panel1.Visible = false;
				panel2.Visible = true;
				panel3.Visible = false;
            }else if (panelNumber == 3)
            {
				panel1.Visible = false;
				panel2.Visible = false;
				panel3.Visible = true;
            }
        }

		

		private async void UserSignedInAsync()
        {
			// Set accountData to match the data from the signed in user.
			// #QUERY
			accountData = await databaseHandler.Child("accounts").Child(firebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();
			if(accountData.accountType == "User")
            {
				ChangePanel(2);
			}
			else if (accountData.accountType == "Admin")
            {
				ChangePanel(3);
            }

				accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}. Account type is {accountData.accountType}";
        }

		private async Task UpdateMessageListAsync()
		{
			msgList =  await databaseHandler.Child("Messages").OnceSingleAsync<List<Message>>();
			if(msgList == null)
            {
				msgList = new List<Message>();
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
				Message tempMsg = new Message(msgBox.Text, DateTime.Now.ToString(), firebaseUser.Email, false); // Message that stores email
				if(msgList != null)
                {
					msgList.Add(tempMsg);
				}
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}
            else 
			{
				// create Message without email address, add to messages, and upload to firebase.
				Message tempMsg = new Message(msgBox.Text, DateTime.Now.ToString(), firebaseUser.Email, true);
				if (msgList != null)
				{
					msgList.Add(tempMsg);
                }
				await databaseHandler.Child("Messages").PutAsync(msgList);
			}
			if(anonymousCheckBox.Checked == false)
            {
				MessageBox.Show("Message sent");
			}
			else if (anonymousCheckBox.Checked == true)
            {
				MessageBox.Show("Anyonymous message sent");
            }

			var mailMessage = new MailMessage
			{
				From = new MailAddress("cis340capstoneteam@gmail.com"),
				Subject = "Message sent",
				IsBodyHtml = true,
			};

            if (anonymousCheckBox.Checked)
            {
				mailMessage.Body = "<body>Thank you for your input to the company! We can assure you your input was anonymous. Here is the message that you sent: <br>" +
				$"{msgBox.Text} <br> Sent {DateTime.Now.ToString()}</body>";
            }
            else
            {
				mailMessage.Body = "<body>Thank you for your input to the company! You chose to send it non-anonymously. Here is the message that you sent: <br>" +
				$"{msgBox.Text} <br> Sent {DateTime.Now.ToString()}</body>";
			}
			mailMessage.To.Add(firebaseUser.Email);

			smtpClient.Send(mailMessage);

			msgBox.Text = "";
			anonymousCheckBox.Checked = false;
        }

		private void SignUserOut()
        {
			ChangePanel(1);
			firebaseUser = null;
			accountData = null;
			adminMsgsListBox.Items.Clear();
			userMsgsListBox.Items.Clear();
			userMsgList = null;
		}

		public Form1()
		{
			InitializeComponent();
		}

		private async void loginButton_Click(object sender, EventArgs e)
		{
			
			if (pageState == "signIn")
			{
				try
				{
					// Sign user in and set firebaseUser as the newly signed in account.
					string email = emailBox.Text;
					string password = passwordBox.Text;
					FirebaseAuthLink userCredential = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
					firebaseUser = userCredential.User;
					UserSignedInAsync();
				}
				catch (Exception error)
				{
					if (error.Message.Contains("INVALID_EMAIL"))
					{
						MessageBox.Show("email must be in user@domain.com form");
					}
					else if (error.Message.Contains("MISSING_PASSWORD"))
					{
						MessageBox.Show("Must enter a password.");
					}
					else if (error.Message.Contains("WEAK_PASSWORD"))
					{
						MessageBox.Show("Password must contain at least 6 characters.");
					}
					else if (error.Message.Contains("WrongPassword"))
					{
						MessageBox.Show("Incorrect password. Please try again.");
					}
					else
					{
						MessageBox.Show(error.Message);
					}
				}
			}
			else if (pageState == "createAccount")
			{
				if (verifyPasswordBox.Text == passwordBox.Text && signUpCodeBox.Text != "")
				{
					try
					{
						// Create account and set firebaseUser as the newly created account. Add account info to database.
						string email = emailBox.Text;
						string password = passwordBox.Text;
						string accountType = null;
						if(signUpCodeBox.Text == "00USER00")
                        {
							accountType = "User";
						}else if(signUpCodeBox.Text == "00ADMIN00"){
							accountType = "Admin";
                        }
						
						if(accountType != null)
                        {
							FirebaseAuthLink userCredential = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
							firebaseUser = userCredential.User;
							string userId = firebaseUser.LocalId;
							// Create an accountInfo object with email and account type. Upload to firebase.
							// #WRITE
							AccountInfo createdAcctInfo = new AccountInfo(firebaseUser.Email, accountType);
							await databaseHandler.Child("accounts").Child(userId).Child("accountInfo").PutAsync(createdAcctInfo);
							UserSignedInAsync();
                        }
                        else
                        {
							MessageBox.Show("Invalid account type. All users must be part of the company.");
                        }

					}
					catch (Exception error)
					{
						if (error.Message.Contains("INVALID_EMAIL"))
						{
							MessageBox.Show("email must be in user@domain.com form");
						}
						else if (error.Message.Contains("MISSING_PASSWORD"))
						{
							MessageBox.Show("Must enter a password.");
						}
						else if (error.Message.Contains("EMAIL_EXISTS"))
						{
							MessageBox.Show("That email already belongs to an account.");
						}
						else if (error.Message.Contains("WEAK_PASSWORD"))
						{
							MessageBox.Show("Password must contain at least 6 characters.");
						}
						else
						{
							MessageBox.Show(error.Message);
						}

					}
				}
				else
				{
					if(verifyPasswordBox.Text != passwordBox.Text)
                    {
						MessageBox.Show("Passwords must match.");
                    }
                    else if (signUpCodeBox.Text == "") {
						MessageBox.Show("You must have an account code.");
                    }
				}
			}
		}

        private void createAccountButton_Click(object sender, EventArgs e)
        {
			// Change panel1 layout based on the state of the screen.
			if (pageState == "signIn")
			{
				pageState = "createAccount";
				verifyPasswordLabel.Visible = true;
				verifyPasswordBox.Visible = true;
				signUpCodeBox.Visible = true;
				accountTypeLabel.Visible = true;
				createAccountButton.Text = "Sign in";
				createAccountLabel.Text = "Already have an account? Click here to sign in";
				loginButton.Text = "Create Account";
			}
            else if(pageState == "createAccount")
            {
				pageState = "signIn";
				verifyPasswordBox.Text = ""; 
				verifyPasswordLabel.Visible = false;
				verifyPasswordBox.Visible = false;
				signUpCodeBox.Visible = false;
				accountTypeLabel.Visible = false;
				createAccountButton.Text = "Create Account";
				loginButton.Text = "Login";
				createAccountLabel.Text = "Don't have an account? Click here to create one";
			}

        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
			SignUserOut();
		}

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
			AddMessage();
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
				foreach (Message msg in msgList)
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
			Message chosenMsg = msgList[adminMsgsListBox.SelectedIndex];
            if (!chosenMsg.anonymous)
            {
				MessageBox.Show($"Message {(adminMsgsListBox.SelectedIndex + 1).ToString()}. Created by {chosenMsg.email} Date/time: {chosenMsg.dateCreated}");

            }
            else
            {
				MessageBox.Show($"Message {(adminMsgsListBox.SelectedIndex + 1).ToString()}. Message created anonymously. Date/time: {chosenMsg.dateCreated}");

			}
		}

        private async void button1_Click(object sender, EventArgs e)
        {
			// Create a list of Messages that were sent from the user's email and show it in the list box.
			String currentUserEmail = firebaseUser.Email;
			userMsgsListBox.Items.Clear();
			await UpdateMessageListAsync();
			userMsgList = new List<Message>(); // added to avoid object being null.
			foreach(Message msg in msgList)
            {
				Console.WriteLine($"{msg.email}: {currentUserEmail}");
				if (msg.email == currentUserEmail)
				{
					userMsgsListBox.Items.Add(msg.message);
					userMsgList.Add(msg);
				}
            }
        }

        private void userMsgListBox_DoubleClick(object sender, EventArgs e)
        {
			Message chosenMsg = userMsgList[userMsgsListBox.SelectedIndex];
            if (!chosenMsg.anonymous)
            {
				MessageBox.Show($"Non-anonymous message. Created {chosenMsg.dateCreated}");
            }
            else
            {
				MessageBox.Show($"Anonymous message. Created {chosenMsg.dateCreated}");
            }
		}
    }
}
