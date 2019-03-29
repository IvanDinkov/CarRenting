using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public static class ChangePassFunction
    {
        public static void ChangePass(string newPassword)
        {
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string commandString = "update CarRenting.dbo.accounts set password = @newpass where id = @id";
            connection.Open();
            using (connection)
            {
                SqlCommand passwordChange = new SqlCommand(commandString, connection);
                passwordChange.Parameters.AddWithValue("newpass", newPassword);
                passwordChange.Parameters.AddWithValue("id", Data.LoggedInAccountID.ID);
                passwordChange.ExecuteNonQuery();
            }
            connection.Close();
        }
        public static string GetEmail()
        {
            string email = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string emailCommand = "select email from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand emailGetter = new SqlCommand(emailCommand, connection))
                {
                    emailGetter.Parameters.AddWithValue("@userid", Data.LoggedInAccountID.ID);
                    SqlDataReader reader = emailGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        email = reader.GetString(0);
                    }
                }
            }
            connection.Close();
            return email;
        }
        public static string GetName()
        {
            string name = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string nameCommand = "select firstname, lastname from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand nameGetter = new SqlCommand(nameCommand, connection))
                {
                    nameGetter.Parameters.AddWithValue("@userid", Data.LoggedInAccountID.ID);
                    SqlDataReader reader = nameGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader.GetString(0) + " " + reader.GetString(1);
                    }
                }
            }
            connection.Close();
            return name;
        }
        public static string GetPass()
        {
            string password = "";
            SqlConnection connection = new SqlConnection(Data.Connection.CONNECTION_STRING);
            string passwordCommand = "select password from CarRenting.dbo.accounts where id = @userid";
            connection.Open();
            using (connection)
            {
                using (SqlCommand passwordGetter = new SqlCommand(passwordCommand, connection))
                {
                    passwordGetter.Parameters.AddWithValue("@userid", Data.LoggedInAccountID.ID);
                    SqlDataReader reader = passwordGetter.ExecuteReader();
                    while (reader.Read())
                    {
                        password = reader.GetString(0);
                    }
                }
            }
            return password;
        }
    }
}
