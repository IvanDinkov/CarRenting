using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Models;

namespace Business
{
    public class CarInfo
    {
        public static void AddInfo()
        {
            var van = new Cars();

           string brand = van.Brand.ToString();
            var model = van.Model;
            var type = van.CarType;
            var price = van.PricePerDay;
            var fuel = van.FuelConsumption;
            var trasmission = van.Transmission;
            var doors = van.DoorCount;
            var seats = van.SeatCount;
            var takenBy = van.TakenBy;

        }

    }

}
