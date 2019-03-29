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
        public AccountSettingsForm()
        {
            InitializeComponent();
        }

        private void AccountSettingsForm_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Business.ChangePassFunction.GetEmail();
            lblName.Text = Business.ChangePassFunction.GetName();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass1 = txtNewPass1.Text;
            string newPass2 = txtNewPass2.Text;
            if (!Business.CheckLoggedInID.IDCheck())
            {
                MessageBox.Show("You can't change your password now.");
            }
            else if (!newPass1.Equals(txtNewPass2.Text))
            {
                MessageBox.Show("New Passwords do not match.");
            }
            else if (!oldPass.Equals(Business.ChangePassFunction.GetPass()))
            {
                MessageBox.Show("Old Password is incorrect.");
            }
            else if (string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass1.Text))
            {
                MessageBox.Show("Password box can not be empty.");
            }
            else
            {
                Business.ChangePassFunction.ChangePass(newPass1);
                MessageBox.Show("Password changed succesfully!");
            }

        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            string newEmail = txtNewEmail.Text;
            if (!Business.CheckLoggedInID.IDCheck())
            {
                MessageBox.Show("You can't change your email now.");
            }
            else if (string.IsNullOrWhiteSpace(txtNewEmail.Text))
            {
                MessageBox.Show("Email box can not be empty.");
            }
            else
            {
                Business.ChangeEmailFunction.ChangeEmail(newEmail);
                MessageBox.Show("Email changed succesfully!");
            }

        }
    }
}
