using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp2.Models;

namespace Business
{
    public static class RentingFunction
    {
        private static CarRentingContext context = new CarRentingContext();
        private static List<Cars> list = context.Cars.ToList();
        public static void Rent(int selectedItem)
        {
            var idOfUser = Data.LoggedInAccountID.ID;
            
            int idSelectedCar = list[selectedItem].Id;
            SqlConnection sqlCon = new SqlConnection(Data.Connection.CONNECTION_STRING);
            sqlCon.Open();

            using (sqlCon)
            {
                SqlCommand sqlCom = new SqlCommand("update CarRenting.dbo.cars set taken_by = @id where id = @brand  ", sqlCon);
                sqlCom.Parameters.AddWithValue("@id", idOfUser);
                sqlCom.Parameters.AddWithValue("@brand", idSelectedCar);
                sqlCom.ExecuteNonQuery();
            }
            sqlCon.Close();
        }
    }
}
