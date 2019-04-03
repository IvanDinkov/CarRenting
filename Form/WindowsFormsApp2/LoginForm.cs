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
        //This method clears the input boxes
        private void LoginClear()
        {
            UsernameBox.Clear();
            PasswordBox.Clear();
        }
        //This method calls the login validations and if they pass, calls the sucessful login method
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;
            StringBuilder ValidationsError = new StringBuilder();
            Business.LoginValidations.LoginValidation(ValidationsError, username, password);
            if (Business.LoginValidations.LoggedIn)
            {
                LoggedIn();
            }
            else
            {
                MessageBox.Show(ValidationsError.ToString());
            }
        }
        //This method closes the whole program
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method opens the register form and closes login form
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Closed += (s, args) => this.Close();
            reg.Show();
        }
        //This method closes the login form after a sucessful login
        private void LoggedIn()
        {
            MessageBox.Show("Logged in sucessfully!");
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }
    }
}
