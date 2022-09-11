using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    public class HGSBuses: HGSRoof
    {
        public static int PassCount = 0;
        public static List<HGSBuses> Buses = new List<HGSBuses>();

        public HGSBuses(string firstName, string lastName, DateTime timestamp) : base(firstName, lastName, timestamp)
        {
            Vehicletype = VehicleType.Bus;
            Balance = +HGSBalance.GetPayment(this.Vehicletype);
            Buses.Add(this);
            PassCount++;
        }

        public VehicleType Vehicletype { get; }
    }
}
