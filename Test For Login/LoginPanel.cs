﻿using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Company_Feedback_System
{
    public partial class LoginPanel : Form
    {
        public static bool devMode { get; set; } = true;

        // Initialize firebase auth and create ability to get the current firebaseUser anywhere in the application.
        private readonly FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyDwSFECwPpPmv8e9c9ycFio6LV6ulLa_fs"));
        private readonly FirebaseClient databaseHandler = new FirebaseClient("https://dotnet-project-3f3cf-default-rtdb.firebaseio.com/");

        private string pageState = "signIn";

        private Firebase.Auth.User firebaseUser;
        private bool exitApplication = true;
        
        public LoginPanel()
        {
            InitializeComponent();
        }

        private async void UserSignedInAsync()
        {
            UserPanel userPanel = new UserPanel();
            userPanel.FirebaseUser = firebaseUser;
            AccountInfo accountData = await databaseHandler.Child("accounts").Child(firebaseUser.LocalId).Child("accountInfo").OrderByKey().OnceSingleAsync<AccountInfo>();

            if (accountData.accountType == "User")
            {
                userPanel.Size = new Size(723, 317);
                userPanel.Show();
                exitApplication = false;
                this.Close();

                List<CompanyMessage> messages = await databaseHandler.Child("adminMessages").OnceSingleAsync<List<CompanyMessage>>();

                //shows most recent admin message
                if(messages != null)
                {
                    // show the last message with the title "Message from your Admin"
                    MessageBox.Show(messages[messages.Count() - 1].message, "Message from your Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else if(accountData.accountType == "Admin")
            {
                userPanel.Size = new Size(319, 362);
                userPanel.Show();
                exitApplication = false;
                this.Close();
            }
        }


        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Change panel1 layout based on the state of the screen.
            if (pageState == "signIn")
            {
                pageState = "createAccount";
                SwitchToCreateAccount();
            }
            else if (pageState == "createAccount")
            {
                pageState = "signIn";
                SwitchToLogin();
            }
        }

        private void SwitchToCreateAccount()
        {
            this.Size = new Size(326, 275);
            verifyPasswordLabel.Visible = true;
            verifyPasswordBox.Visible = true;
            signUpCodeBox.Visible = true;
            accountTypeLabel.Visible = true;
            createAccountButton.Text = "Sign in";
            createAccountButton.Location = new Point(86, 180);
            createAccountLabel.Text = "Already have an account? Click here to sign in";
            createAccountLabel.Location = new Point(33, 156);
            loginButton.Text = "Create Account";
            loginButton.Location = new Point(160, 115);
            label1.Visible = true;
        }
        private void SwitchToLogin()
        {
            this.Size = new Size(326, 207);
            verifyPasswordBox.Text = "";
            verifyPasswordLabel.Visible = false;
            verifyPasswordBox.Visible = false;
            signUpCodeBox.Visible = false;
            accountTypeLabel.Visible = false;
            label1.Visible = false;
            createAccountButton.Text = "Create Account";
            createAccountButton.Location = new Point(86, 137);
            loginButton.Text = "Login";
            loginButton.Location = new Point(160, 65);
            createAccountLabel.Text = "Don't have an account? Click here to create one";
            createAccountLabel.Location = new Point(33, 113);

        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.FormClosing += LoginPanel_FormClosing;
            SwitchToLogin();
        }

        private void LoginPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            // exit the application on close if 
            if (exitApplication)
            {
                Application.Exit();
            }
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
                        if (signUpCodeBox.Text == "00USER00")
                        {
                            accountType = "User";
                        }
                        else if (signUpCodeBox.Text == "00ADMIN00")
                        {
                            accountType = "Admin";
                        }

                        if (accountType != null)
                        {
                            FirebaseAuthLink userCredential = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                            firebaseUser = userCredential.User;
                            string userId = firebaseUser.LocalId;
                            // Create an accountInfo object with email and account type. Upload to firebase.
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
                    if (verifyPasswordBox.Text != passwordBox.Text)
                    {
                        MessageBox.Show("Passwords must match.");
                    }
                    else if (signUpCodeBox.Text == "")
                    {
                        MessageBox.Show("You must have an account code to prove you're part of the company.");
                    }
                }
            }
        }
    }
}
