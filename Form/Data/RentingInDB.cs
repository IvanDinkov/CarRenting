using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Models;
using System.Data.SqlClient;

namespace Data
{
    public class RentingInDB
    {
        private static CarRentingContext context = new CarRentingContext();
        private static List<Cars> list = context.Cars.ToList();
        //This method adds the user's ID into the taken_by column of the current car into the database
        public static void Rent(int selectedItem)
        {
            var idOfUser = Data.LoggedInAccountID.ID;
            int idSelectedCar = list[selectedItem].Id;
            SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
            sqlCon.Open();

            using (sqlCon)
            {
                SqlCommand sqlCom = new SqlCommand("update CarRenting.dbo.cars set taken_by = @id where id = @CarID  ", sqlCon);
                sqlCom.Parameters.AddWithValue("@id", idOfUser);
                sqlCom.Parameters.AddWithValue("@CarID", idSelectedCar);
                sqlCom.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
    }
}
