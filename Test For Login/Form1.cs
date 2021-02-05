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
		public Form1()
		{
			InitializeComponent();
		}

		


		private async void button1_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
            try
			{
				var userCredential = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
				var user = userCredential.User;
				var userEmail = user.Email;
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
				}else if (error.Message.Contains("WrongPassword"))
                {
					MessageBox.Show("Incorrect password. Please try again.");
                }else
                {
					MessageBox.Show(error.Message);
				}
				
				

			}
			
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
			try
			{
				var login = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
				MessageBox.Show($"Account created successfully");
			}catch(Exception error)
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
	}
}
