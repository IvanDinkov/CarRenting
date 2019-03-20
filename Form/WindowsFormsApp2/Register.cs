using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Firstname = txtFirstname.Text;
            string Lastname = txtLastname.Text;            
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfPassword.Text;
            string Email = txtEmail.Text;
            
            StringBuilder failedValidations = new StringBuilder(500);
            fullValidation(failedValidations, Username, Firstname, Lastname, Password, ConfirmPassword, Email);
            if (failedValidations.ToString() == "")
            {
                SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
                sqlCon.Open();

                using (sqlCon)
                {
                    SqlCommand sqlCom = new SqlCommand("Insert into CarRenting.dbo.accounts (Firstname,Lastname,Username,Password, Email) values (@Firstname, @Lastname, @Username, @Password, @Email)", sqlCon);
                    sqlCom.Parameters.AddWithValue("@Firstname", Firstname);
                    sqlCom.Parameters.AddWithValue("@Lastname", Lastname);
                    sqlCom.Parameters.AddWithValue("@Username", Username);
                    sqlCom.Parameters.AddWithValue("@Password", Password);
                    sqlCom.Parameters.AddWithValue("@Email", Email.ToString());
                    sqlCom.ExecuteNonQuery();
                }
                sqlCon.Close();

                MessageBox.Show("Registered sucessfully!");

                this.Hide();
                LoginForm form = new LoginForm();
                form.Closed += (s, args) => this.Close();
                form.Show();


            }
            else
            {
                MessageBox.Show(failedValidations.ToString());
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtConfPassword.Clear();
            txtEmail.Clear();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void fullValidation(StringBuilder validation, string username, string firstname, string lastname, string password, string confirmedPassword, string email)
        {
            NamesValidation(validation, firstname);
            NamesValidation(validation, lastname);
            PasswordValidation(validation, password, confirmedPassword);
            UsernameAndEmailValidation(validation, username, email);
        }
        private void NamesValidation(StringBuilder validation, string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                validation.AppendLine("Name should be longer.");
            }
        }
        private void PasswordValidation(StringBuilder validation, string Password, string secondPassword)
        {
            if (Password.Length < 5)
            {
                validation.AppendLine("Password should be longer.");
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                validation.AppendLine("Password shouldn't be empty.");
            }
            if (Password != secondPassword)
            {
                validation.AppendLine("Passwords don't match.");
            }
        }
        private void UsernameAndEmailValidation(StringBuilder validation, string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            {
                validation.AppendLine("Username should be longer.");
            }
            if (string.IsNullOrWhiteSpace(email) || email.Length < 3)
            {
                validation.AppendLine("Email isn't valid.");
            }
            else
            {
                DBEmailAndUsernameCheck(validation, username, email);
            }
        }
        private void DBEmailAndUsernameCheck(StringBuilder validation,string username, string email)
        {
            bool freeUsername = false;
            bool freeEmail = false;
            string usernameCommandCheck = $"Select * from CarRenting.dbo.accounts where username = '{username}';";
            SqlConnection con = new SqlConnection(Data.Connection.CONNECTION_STRING);
            con.Open();
            using (con)
            {
                using (SqlCommand commandCall = new SqlCommand(usernameCommandCheck, con))
                {
                    SqlDataReader reader = commandCall.ExecuteReader();
                    if (reader.HasRows)
                    {
                        freeUsername = false;
                        con.Close();
                    }
                    else
                    {
                        freeUsername = true;
                        con.Close();
                    }
                }
                string emailCommandCheck = $"Select * from CarRenting.dbo.accounts where email = '{email}';";
                using (SqlCommand commandCall = new SqlCommand(emailCommandCheck, con))
                {
                    con.Open();
                    SqlDataReader reader = commandCall.ExecuteReader();
                    if (reader.HasRows)
                    {
                        freeEmail = false;
                    }
                    else
                    {
                        freeEmail = true;
                    }
                }
            }
            con.Close();
            if (!freeEmail)
            {
                validation.AppendLine("This E-mail is already in use.");
            }
            if (!freeUsername)
            {
                validation.AppendLine("This Username is already in use.");
            }
        }
    }
}
