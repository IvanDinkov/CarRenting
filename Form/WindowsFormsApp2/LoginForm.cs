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
            StringBuilder ValidationsError = new StringBuilder();
            Business.LoginFunctions.LoginValidation(ValidationsError, username, password);
            if (Business.LoginFunctions.LoggedIn)
            {
                LoggedIn();
            }
            else
            {
                MessageBox.Show(ValidationsError.ToString());
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
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Closed += (s, args) => this.Close();
            MainForm.Show();
        }
    }
}
