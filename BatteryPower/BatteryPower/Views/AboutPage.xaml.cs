using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatteryPower.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            AboutApp();
        }
        private void AboutApp()
        {
            string currentVersion = VersionTracking.CurrentVersion;
            loads.Text = "Loads:\nLoads are measured in Watts. If you are using 20 Watts (20W) fan and a 15 Watts radio, total watts will be 20 + 15, which equals 35 Watts\n\n";
            capacity.Text = "Battery AH:\nAmpere hour (AH) is the unit of electric charge of a battery. If you have two (2) 150AH batteries, the total AH will be 300AH\n\n";
            voltage.Text = "Voltage:\n12 Voltage of battery and 24 voltage of battery equals 36 voltage.\n\n";
            WattHour.Text = "Watt Hour:\nHours a battery should last when fully charged.\n\n";
            about.Text = "Please, note that battery may last longer or shorter than what is calculated.\n\nThis calculator is based on average\n\nVersion "+ currentVersion + " \n\nContact: \nadamsondamilola@gmail.com";
        }
    }
}