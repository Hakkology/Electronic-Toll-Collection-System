using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakan.HGS.FormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //emulated vehicles passing through HGS
            new HGSCars("George", "Michael", DateTime.Now);
            new HGSCars("Katell", "Armell", DateTime.Now);
            new HGSCars("Arzhel", "Franseza", DateTime.Now);
            new HGSCars("Corentin", "Annaig", DateTime.Now);
            new HGSCars("Brandon", "Sanderson", DateTime.Now.AddDays(1));
            new HGSCars("Corentin", "Annaig", DateTime.Now.AddDays(1));

            new HGSBuses("John", "Constantine", DateTime.Now);
            new HGSBuses("Mark", "Mezentcev", DateTime.Now);
            new HGSBuses("Frank", "Herbert", DateTime.Now.AddDays(1));

            new HGSMinibuses("Hakan", "Yıldız", DateTime.Now);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
