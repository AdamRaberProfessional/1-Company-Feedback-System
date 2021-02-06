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
		private FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
		private Firebase.Auth.User firebaseUser;
		private string pageState = "signIn";
		public Firebase.Auth.User GetFirebaseUser()
		{
			return firebaseUser;
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
					var userCredential = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
					firebaseUser = userCredential.User;
					var userEmail = firebaseUser.Email;
					MessageBox.Show($"signed in as {userEmail}");

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
				if(textBox1.Text == passwordBox.Text) {
					try
					{
						var userCredential = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
						firebaseUser = userCredential.User;
						MessageBox.Show($"Account created for {firebaseUser.Email}");

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
			if (pageState == "signIn")
			{
				pageState = "createAccount";
				label2.Visible = true;
				textBox1.Visible = true;
				button3.Text = "Sign in";
				label3.Text = "Already have an account? Click here to sign in";
				button1.Text = "Create Account";
			}
            else
            {
				pageState = "signIn";
				textBox1.Text = ""; 
				label2.Visible = false;
				textBox1.Visible = false;
				button3.Text = "Create Account";
				button1.Text = "Login";
				label3.Text = "Don't have an account? Click here to create one";
			}

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void ShowPageButton_Click(object sender, EventArgs e)
		{
			//NewPage np = new NewPage();
			//np.Show();
			panel1.Visible = false;
			panel2.Visible = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//authProvider.Dispose();
			panel2.Visible = false;
			panel1.Visible = true;
		}
		private void CreateNewAuthProvider()
		{
			
			
		}
	}
}
