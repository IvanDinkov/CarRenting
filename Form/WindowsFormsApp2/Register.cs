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
        //This method calls the register validations and if they pass, calls the sucessful register method
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Firstname = txtFirstname.Text;
            string Lastname = txtLastname.Text;
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfPassword.Text;
            string Email = txtEmail.Text;

            StringBuilder failedValidations = new StringBuilder(500);
            Business.RegisterFunctions.fullValidation(failedValidations, Username, Firstname, Lastname, Password, ConfirmPassword, Email);
            if (failedValidations.ToString() == "")
            {
               Data.RegisterInDB.SuccessfulValidation(Firstname, Lastname, Username, Password, Email);

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
        //This method clears the input boxes
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtConfPassword.Clear();
            txtEmail.Clear();
        }
        //This method closes the register form and opens the login form
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
    }
}
