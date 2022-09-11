using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    //Vehicle Types as Navigational Property
    public enum VehicleType
    {
        Car,
        Minibus,
        Bus
    }
    //Interface for all VehicleTypes
    internal interface IHGSContext
    {
        int Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime TimeStamp { get; set; }
    }
}
