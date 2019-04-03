using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public class LoginValidations
    {
        public static bool LoggedIn { get; private set; }
        //This method checks if the username and password are valid in the application
        public static void LoginValidation(StringBuilder validations, string username, string password)
        {
            username = username.Trim(' ', '.', '[', ']', '\'', '\"');
            if (string.IsNullOrWhiteSpace(username))
            {
                validations.AppendLine("Username can't be empty.");
                LoggedIn = false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                validations.AppendLine("Password can't be empty.");
                LoggedIn = false;
            }
            else
            {
                LoginValidationInDB(validations, username, password);
            }
        }
        //This method checks if the login credentials are present in the database
        private static void LoginValidationInDB(StringBuilder validation, string username, string password)
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
                        while (reader.Read())
                        {
                            Data.LoggedInAccountID.ID = reader.GetInt32(0);
                        }
                        LoggedIn = true;
                    }
                    else
                    {
                        validation.AppendLine($"Your username {username} or password is incorrect. Please try again.");
                        LoggedIn = false;
                    }
                }
            }
            connection.Close();
        }
    }
}
