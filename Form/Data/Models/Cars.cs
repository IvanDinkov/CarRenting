using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Models
{
    public partial class Cars
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarType { get; set; }
        public decimal PricePerDay { get; set; }
        public string FuelConsumption { get; set; }
        public string Transmission { get; set; }
        public int DoorCount { get; set; }
        public int SeatCount { get; set; }
        public int? TakenBy { get; set; }
        public byte[] Picture { get; set; }
    }
}
