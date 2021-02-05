using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Test_For_Login
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "82cddLuPtNIXu26qHCfjY59oGg73C6PSQjGRw3Vb",
			BasePath = "https://cis-attempt-1-default-rtdb.firebaseio.com/"
		};

		private void button1_Click(object sender, EventArgs e)
		{
			string email = emailBox.Text;
			string password = passwordBox.Text;
			MessageBox.Show($"{email} {password}");
		}
		IFirebaseClient client;
		private void button2_Click(object sender, EventArgs e)
		{
			client = new FireSharp.FirebaseClient(config);
			if (client != null)
			{
				MessageBox.Show("Connection Established");
				string email = emailBox.Text;
				string password = passwordBox.Text;
				try
				{
					client.CreateUser(email, password);
				}catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				
				MessageBox.Show($"A new user has been successfully created with the email: {email}");
			}
		}
	}
}
