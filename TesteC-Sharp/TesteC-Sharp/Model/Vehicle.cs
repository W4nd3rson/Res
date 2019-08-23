using System;
using TesteC_Sharp.Interfaces;

namespace TesteC_Sharp.Model
{
    public abstract class Vehicle: IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double MinValue { get; set; }
    }
}
