using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public class RegisterFunctions
    {
        public static void SuccessfulValidation(string Firstname, string Lastname, string Username, string Password, string Email)
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
                sqlCom.Parameters.AddWithValue("@Email", Email);
                sqlCom.ExecuteNonQuery();
            }
            sqlCon.Close();
        }

        public static void fullValidation(StringBuilder validation, string username, string firstname, string lastname, string password, string confirmedPassword, string email)
        {
            NamesValidation(validation, firstname);
            NamesValidation(validation, lastname);
            PasswordValidation(validation, password, confirmedPassword);
            UsernameAndEmailValidation(validation, username, email);
        }

        private static void NamesValidation(StringBuilder validation, string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                validation.AppendLine("First/Last name should be longer.");
            }
        }

        private static void PasswordValidation(StringBuilder validation, string Password, string secondPassword)
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

        private static void UsernameAndEmailValidation(StringBuilder validation, string username, string email)
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

        private static void DBEmailAndUsernameCheck(StringBuilder validation, string username, string email)
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
