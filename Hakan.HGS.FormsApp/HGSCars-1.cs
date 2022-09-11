using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    public class HGSCars : HGSRoof
    {
        public static int PassCount = 0;
        public static List<HGSCars> Cars = new List<HGSCars>();

        public HGSCars(string firstName, string lastName, DateTime timestamp) : base(firstName, lastName, timestamp)
        {
            Vehicletype = VehicleType.Car;
            Balance = +HGSBalance.GetPayment(this.Vehicletype);
            Cars.Add(this);
            PassCount++;
        }

        public VehicleType Vehicletype { get; }
    }
}
