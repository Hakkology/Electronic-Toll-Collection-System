using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakan.HGS.FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cars.Click += Cars_Click;
            Minibuses.Click += Minibuses_Click;
            Buses.Click += Buses_Click;
            Note.Text = String.Format("Specific quantities of vehicles have been emulated for testing. Please enter date as today and tomorrow for checking.");
        }

        private void Buses_Click(object sender, EventArgs e)
        {
            HGSBalance.BusBalance = 0;
            foreach (var item in HGSBuses.Buses)
            {
                if (item.TimeStamp.Day == dateTimePicker1.Value.Day && item.TimeStamp.Month == dateTimePicker1.Value.Month && item.TimeStamp.Year == dateTimePicker1.Value.Year)
                {
                    HGSBalance.BusBalance += item.Balance;
                }
            }
            Result.Text = String.Format($"{HGSBuses.PassCount} buses have passed so far.\n" +
            $"Bus Vehicle Balance is {HGSBalance.BusBalance}");
        }

        private void Minibuses_Click(object sender, EventArgs e)
        {
            HGSBalance.MinibusBalance = 0;
            foreach (var item in HGSMinibuses.Minibuses)
            {
                if (item.TimeStamp.Day == dateTimePicker1.Value.Day && item.TimeStamp.Month == dateTimePicker1.Value.Month && item.TimeStamp.Year == dateTimePicker1.Value.Year)
                {
                    HGSBalance.MinibusBalance += item.Balance;
                }
            }
            Result.Text = String.Format($"{HGSMinibuses.PassCount} minibuses have passed so far.\n" +
            $"Minibus Vehicle Balance is {HGSBalance.MinibusBalance}");
        }

        private void Cars_Click(object sender, EventArgs e)
        {
            HGSBalance.CarBalance = 0;
            foreach (var item in HGSCars.Cars)
            {
                if (item.TimeStamp.Day == dateTimePicker1.Value.Day && item.TimeStamp.Month == dateTimePicker1.Value.Month && item.TimeStamp.Year == dateTimePicker1.Value.Year)
                {
                    HGSBalance.CarBalance += item.Balance;
                }
            }
            Result.Text = String.Format($"{HGSCars.PassCount} cars have passed so far.\n" +
            $"Car Vehicle Balance is {HGSBalance.CarBalance}");
        }
    }
}
