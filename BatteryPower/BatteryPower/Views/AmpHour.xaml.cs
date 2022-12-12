using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BatteryPower.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmpHour : ContentPage
    {
        public AmpHour()
        {
            InitializeComponent();
        }
        public async void SimpleAlert(string title, string message)
        {
            await DisplayAlert(title, message, "OK");
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Double result = Double.Parse(WattHour.Text) * Double.Parse(loads.Text) / Double.Parse(voltage.Text);
                result = result * 1.5; //reduce answer by 1.5 to get average
                if (result > 0)
                {
                    await DisplayAlert("Result", "Minimum of "+ result.ToString() + " AH and "+ voltage.Text + " Voltage of battery is needed to power "+ loads.Text + " Watts of loads for "+ WattHour.Text + " hours", "OK");
                }
                
            }
            catch (Exception)
            {

                await DisplayAlert("Error", "Error calculating. Make sure no field is empty and try again", "OK");
            }
        }


        private void Button_Clicked_10(object sender, EventArgs e)
        {
            int vol = 12;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            int vol = 24;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            int vol = 36;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            int vol = 48;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {
            int vol = 96;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {
            int vol = 192;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_16(object sender, EventArgs e)
        {
            int vol = 384;
            try
            {
                voltage.Text = (int.Parse(voltage.Text) + vol).ToString();
            }
            catch (Exception)
            {
                voltage.Text = vol.ToString();
            }
        }

        private void Button_Clicked_17(object sender, EventArgs e)
        {
            voltage.Text = "";
        }



        private void Button_Clicked_18(object sender, EventArgs e)
        {
            voltage.Text = WattHour.Text = loads.Text = "";

        }

        private void TotalBatteryCapacity_Tapped(object sender, EventArgs e)
        {
            SimpleAlert("Total Battery Capacity", "Ampere hour (AH) is the unit of electric charge of a battery. If you have two (2) 150AH batteries, the total AH will be 300AH");
        }

        private void TotalLoadsWatts_Tapped(object sender, EventArgs e)
        {
            SimpleAlert("Total Loads Watts", "Loads are measured in Watts. If you are using 20 Watts (20W) fan and a 15 Watts radio, total watts will be 20 + 15, which equals 35 Watts");
        }

        private void BatteryVoltage_Tapped(object sender, EventArgs e)
        {
            SimpleAlert("Battery Voltage", "12 Voltage of battery and 24 voltage of battery equals 36 voltage.");
        }

        private void WattHourInfo_Tapped(object sender, EventArgs e)
        {
            SimpleAlert("Watt Hour", "Hours battery should last when fully charged.");
        }
    }
}