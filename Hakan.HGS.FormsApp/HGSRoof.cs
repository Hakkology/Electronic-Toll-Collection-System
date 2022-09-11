using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan.HGS.FormsApp
{
    public class HGSRoof : IHGSContext
    {
        //holds FirstName, LastName and TimeStamp
        public HGSRoof(string firstName, string lastName, DateTime timestamp)
        {
            Id++;
            FirstName = firstName;
            LastName = lastName;
            TimeStamp = timestamp;
        }

        public int Id { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal Balance { get; set; } = 0;

    }
}
