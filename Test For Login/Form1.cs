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

	

		private void button1_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			MessageBox.Show($"{email} {password}");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAsFiSNedHZ6LohezUzZ-Y7FoflxRZmwWA"));
			var auth = authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
			MessageBox.Show($"User Created");

		}
	}
}
