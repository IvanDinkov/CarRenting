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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
                  
            string userName = txtUsername.Text;
            string lastName = txtLastname.Text;
            string firstName = txtFirstname.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string confirmPassword = txtConfPassword.Text;
            StringBuilder sb = new StringBuilder();

            if (userName.Length <= 3)
            {
                sb.AppendLine("Username should be longer");
                
            }
            if (firstName.Length <= 3)
            {
                sb.AppendLine("First name should be longer");
                
            }
            if (lastName.Length <= 3)
            {
                sb.AppendLine("Last Name should be longer");
                
            }
            if (password.Length <= 3)
            {
                sb.AppendLine("Password should be longer");
                
            }
            if (email.Length <= 7)
            {
                sb.AppendLine("E-mail should be longer");
                
            }
            if (password != confirmPassword)
            {
                sb.AppendLine("Password do not match!");
            }

            if (sb.ToString() == "")
            {
                SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
                sqlCon.Open();

                using (sqlCon)
                {
                    SqlCommand sqlCom = new SqlCommand("insert into CarRenting.dbo.accounts (firstname,lastname,username,password) values (@firstname, @lastname, @username, @password)", sqlCon);
                    sqlCom.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    sqlCom.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    sqlCom.Parameters.AddWithValue("@username", txtUsername.Text);
                    sqlCom.Parameters.AddWithValue("@password", txtPassword.Text);
                    sqlCom.ExecuteNonQuery();

                }
            }
            else
            {
                MessageBox.Show(sb.ToString());
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtConfPassword.Clear();
            txtEmail.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
