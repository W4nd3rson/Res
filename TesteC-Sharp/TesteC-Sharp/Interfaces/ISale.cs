using System;
using System.Collections.Generic;
using System.Text;
using TesteC_Sharp.Model;
using static TesteC_Sharp.Model.Enumerators;

namespace TesteC_Sharp.Interfaces
{
    public interface ISale
    {
        Dictionary<SaleStatus, List<Vehicle>> SaleAnVehicle(double SaleValue, Vehicle vehicle);
    }
}
