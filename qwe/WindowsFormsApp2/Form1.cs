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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            string userName;
            string passWord;
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            connection.Open();

            using (connection)
            {
                SqlCommand cmd = new SqlCommand("select * from CarRenting.dbo.accounts where id = 1;", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                using (cmd)
                {
                    while (reader.Read())
                    {
                        userName = (string)reader["username"];
                        passWord = (string)reader["password"];
                        if (username == userName && password == passWord)
                        {
                            var message = MessageBox.Show("zdr", "bravo", MessageBoxButtons.YesNo);                         
                           
                            
                        }
                        else
                        {
                            var message2 = MessageBox.Show("ei pedal", "ooooooooooouof", MessageBoxButtons.OKCancel);
                        }
                    }
                }
            }
            connection.Close();

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register reg = new Register();
            reg.Closed += (s, args) => this.Close();
            reg.Show();

        }
    }
}
