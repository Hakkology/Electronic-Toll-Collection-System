using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    public class HGSBalance
    {
        public static decimal CarBalance = 0;
        public static decimal MinibusBalance = 0;
        public static decimal BusBalance = 0;

        //Initial function to define discounts according to vehicle type
        public static decimal GetPayment(VehicleType a)
        {
            decimal discount;
            decimal VAT = 1.18M;
            decimal Payment = 50M;

            if (a == VehicleType.Car)
            {
                discount = 0.4M;
            }
            else if (a == VehicleType.Minibus)
            {
                discount = 0.3M;
            }
            else if (a == VehicleType.Bus)
            {
                discount = 0.2M;
            }
            else
            {
                discount = 0M;
            }

            return Payment * VAT * (1 - discount);
        }
    }
}
