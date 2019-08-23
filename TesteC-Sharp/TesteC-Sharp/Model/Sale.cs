using System;
using System.Collections.Generic;
using System.Text;
using TesteC_Sharp.Interfaces;
using static TesteC_Sharp.Model.Enumerators;

namespace TesteC_Sharp.Model
{
    public class Sale : ISale
    {
        private Dictionary<SaleStatus, List<Vehicle>> vehiclesAndSaleStatus = new Dictionary<SaleStatus, List<Vehicle>>();
        private List<Vehicle> allVehicles = new List<Vehicle>();
        public Dictionary<SaleStatus, List<Vehicle>> SaleAnVehicle(double saleValue, Vehicle vehicle)
        {
            VehicleSale(saleValue, vehicle);
            return vehiclesAndSaleStatus;
        }

        private void VehicleSale(double saleValue, Vehicle vehicle)
        {
            if (saleValue < vehicle.MinValue)
            {
                vehiclesAndSaleStatus.Add(SaleStatus.rejectedByMinValue, allVehicles.FindAll(x => x.MinValue >= saleValue));
            }
            vehiclesAndSaleStatus.Add(SaleStatus.sold,new List<Vehicle>());
        }
    }
}
