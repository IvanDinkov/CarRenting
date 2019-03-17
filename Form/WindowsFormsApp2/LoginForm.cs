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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginClear()
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username or Password cannot be empty!");
                LoginClear();
            }
            else
            {
                SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
                connection.Open();

                using (connection)
                {
                    string LoginCheckCommand = "select * from CarRenting.dbo.accounts where username = @username and password = @password;";
                    using (SqlCommand login = new SqlCommand(LoginCheckCommand, connection))
                    {
                        login.Parameters.AddWithValue("@username", username);
                        login.Parameters.AddWithValue("@password", password);
                        SqlDataReader reader = login.ExecuteReader();
                        if (reader.HasRows)
                        {
                            LoggedIn();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password. Please try again!");
                            LoginClear();
                        }
                    }
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Closed += (s, args) => this.Close();
            reg.Show();
        }

        private void LoggedIn()
        {
            MessageBox.Show("Logged in sucessfully!");
            //LoginForm login = new LoginForm();
            //login.Close();
            //LoginClear();
            //MainForm LoggedIn = new MainForm();
            //LoggedIn.Show();
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }
    }
}
