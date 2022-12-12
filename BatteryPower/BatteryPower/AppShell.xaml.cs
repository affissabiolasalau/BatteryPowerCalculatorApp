using BatteryPower.ViewModels;
using BatteryPower.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BatteryPower
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AmpHour), typeof(AmpHour));
        }

    }
}
