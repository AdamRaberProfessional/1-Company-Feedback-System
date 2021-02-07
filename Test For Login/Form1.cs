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


namespace Test_For_Login
{
	public partial class Form1 : Form
	{
		// Initialize firebase auth and create ability to get the current firebaseUser anywhere in the application.
		private readonly FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
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

		private void UserSignedIn()
        {
			//change to panel2 and show that the user is signed in.
			ChangePanel(2);
			accountInfoLabel.Text = $"Signed in as {firebaseUser.Email}";
        }

		public Form1()
		{
			InitializeComponent();
		}


		private async void button1_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			if (pageState == "signIn")
            {
				try
				{
					// Sign user in and set firebaseUser as the newly signed in account.
					var userCredential = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
					firebaseUser = userCredential.User;
					UserSignedIn();

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
            else
            {
				if(verifyPasswordBox.Text == passwordBox.Text) {
					try
					{
						// Create account and set firebaseUser as the newly created account.
						var userCredential = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
						firebaseUser = userCredential.User;
						UserSignedIn();
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
					MessageBox.Show("Passwords must match.");
                }

			}
			
           
			
		}

		

        private void button3_Click(object sender, EventArgs e)
        {
			// Change panel1 layout based on the state of the screen.
			if (pageState == "signIn")
			{
				pageState = "createAccount";
				verifyPasswordLabel.Visible = true;
				verifyPasswordBox.Visible = true;
				createAccountButton.Text = "Sign in";
				createAccountLabel.Text = "Already have an account? Click here to sign in";
				loginButton.Text = "Create Account";
			}
            else
            {
				pageState = "signIn";
				verifyPasswordBox.Text = ""; 
				verifyPasswordLabel.Visible = false;
				verifyPasswordBox.Visible = false;
				createAccountButton.Text = "Create Account";
				loginButton.Text = "Login";
				createAccountLabel.Text = "Don't have an account? Click here to create one";
			}

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void ShowPageButton_Click(object sender, EventArgs e)
		{
			//NewPage np = new NewPage();
			//np.Show();
			ChangePanel(2);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//authProvider.Dispose();
			
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
			ChangePanel(1);
			firebaseUser = null;
		}
    }
}
