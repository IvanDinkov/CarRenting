using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class AccountSettingsForm : Form
    {
        StringBuilder validationErrors = new StringBuilder();
        public AccountSettingsForm()
        {
            InitializeComponent();
        }

        private void AccountSettingsForm_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Data.GetEmail.GetMail();
            lblName.Text = Data.GetName.GetFirstAndLastName();
        }
        //This method calls the validations for the password change function and then changes the password if the validations have passed
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            validationErrors.Clear();
            string oldPass = txtOldPass.Text;
            string newPass1 = txtNewPass1.Text;
            string newPass2 = txtNewPass2.Text;
            Business.ChangePassValidations.ChangePass(validationErrors, oldPass, newPass1, newPass2);
            if (validationErrors.ToString() == "")
            {
                Data.ChangePassInDB.ChangePassInDataBase(newPass1);
                txtOldPass.Clear();
                txtNewPass1.Clear();
                txtNewPass2.Clear();
                MessageBox.Show("Password changed succesfully!");
            }
            else
            {
                MessageBox.Show(validationErrors.ToString());
            }
        }
        //This method calls the validations for changing email and if they pass, changes the email
        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            validationErrors.Clear();
            string newEmail = txtNewEmail.Text;
            Business.ChangeEmailValidations.ChangeEmailValid(validationErrors, newEmail);
            if (validationErrors.ToString() == "")
            {
                Data.ChangeEmailInDB.ChangeEmail(newEmail);
                txtNewEmail.Clear();
                MessageBox.Show("Email changed succesfully!");
            }
            else
            {
                MessageBox.Show(validationErrors.ToString());
            }
        }
    }
}
