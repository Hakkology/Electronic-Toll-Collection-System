using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    public class HGSMinibuses: HGSRoof
    {
        public static int PassCount = 0;
        public static List<HGSMinibuses> Minibuses = new List<HGSMinibuses>();

        public HGSMinibuses(string firstName, string lastName, DateTime timestamp) : base(firstName, lastName, timestamp)
        {
            Vehicletype = VehicleType.Minibus;
            Balance = +HGSBalance.GetPayment(this.Vehicletype);
            Minibuses.Add(this);
            PassCount++;
        }

        public VehicleType Vehicletype { get; }
    }
}
