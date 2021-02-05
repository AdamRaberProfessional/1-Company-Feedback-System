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
				var login = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
				MessageBox.Show($"{login}");
			}
            catch (Exception error)
            {
				Console.WriteLine(error.Message);
				MessageBox.Show(error.Message);
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
				MessageBox.Show($"{login}");
			}catch(Exception excp)
            {
				MessageBox.Show(excp.Message);
            }

		}
	}
}
