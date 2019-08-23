using System;
using System.Collections.Generic;
using System.Text;

namespace TesteC_Sharp.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double MinValue { get; set; }
    }
}
