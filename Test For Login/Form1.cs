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


// how do I make the click function names match the button names?

namespace Test_For_Login
{
	public partial class Form1 : Form
	{
		// Initialize firebase auth and create ability to get the current firebaseUser anywhere in the application.
		private readonly FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
		private readonly FirebaseClient databaseHandler = new FirebaseClient("https://cis-attempt-1-default-rtdb.firebaseio.com/");
		private AccountInfo accountData;
		private string pageState = "signIn";
		private Firebase.Auth.User firebaseUser;

		private void ChangePanel(int panelNumber)
        {
			// Change the panel according to the panelNumber given. 
			if(panelNumber == 1)
            {
				panel1.Visible = true;
				panel2.Visible = false;
			}else if(panelNumber == 2)
            {
				panel1.Visible = false;
				panel2.Visible = true;
            }
        }

		

		private async void UserSignedInAsync()
        {
			// Set accountData to match the data from the signed in user.
			var accountDataList = await databaseHandler.Child(firebaseUser.LocalId).OrderByKey().OnceAsync<AccountInfo>();
			foreach (var acc in accountDataList)
			{
				accountData = acc.Object;
			}
			ChangePanel(2);
			accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}. Account type is {accountData.accountType}";
			MessageBox.Show($"{accountData.emailAddress} is type {accountData.accountType}");
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
					var userCredential = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
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
				if (verifyPasswordBox.Text == passwordBox.Text && accountTypeBox.Text != "")
				{
					try
					{
						// Create account and set firebaseUser as the newly created account. Add account info to database.
						string email = emailBox.Text;
						string password = passwordBox.Text;
						string accountType = accountTypeBox.Text;
						var userCredential = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
						firebaseUser = userCredential.User;
						string userId = firebaseUser.LocalId;
						// Create an accountInfo object with email and account type. Upload to firebase.
						AccountInfo createdAcctInfo = new AccountInfo(firebaseUser.Email, accountTypeBox.Text);
						await databaseHandler.Child(userId).Child("accountInfo").PutAsync(createdAcctInfo);
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
                    else if (accountTypeBox.Text == "") {
						MessageBox.Show("Must choose an account type");
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
				accountTypeBox.Visible = true;
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
				accountTypeBox.Visible = false;
				accountTypeLabel.Visible = false;
				createAccountButton.Text = "Create Account";
				loginButton.Text = "Login";
				createAccountLabel.Text = "Don't have an account? Click here to create one";
			}

        }
        


        private void signOutButton_Click(object sender, EventArgs e)
        {
			ChangePanel(1);
			firebaseUser = null;
			accountData = null;
		}
	}
}
