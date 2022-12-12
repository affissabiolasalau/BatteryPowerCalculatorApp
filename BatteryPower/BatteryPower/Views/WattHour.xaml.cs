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
    public partial class WattHour : ContentPage
    {
        public WattHour()
        {
            InitializeComponent();
        }

     
        public async void SimpleAlert(string title, string message)
        {
            await DisplayAlert(title, message, "OK");
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            /*
             if(double.Parse(loads.Text) > double.Parse(capacity.Text))
            {
                SimpleAlert("Error", "Load is too much on battery");
            } */

            try
            {
                int result = int.Parse(capacity.Text) * int.Parse(voltage.Text) / int.Parse(loads.Text);
                Double result_ = result / 1.5; //reduce answer by 1.5 to get average
                int days = int.Parse(result.ToString()) / 24;
                int hoursleft = int.Parse(result_.ToString()) % 24;
                if (result > 1 && result < 24)
                {
                    await DisplayAlert("Result", "Battery will last approximately " + result.ToString() + " hours", "OK");
                }
                else if (days == 1 && hoursleft > 1)
                {

                    await DisplayAlert("Result", "Battery will last approximately " + days + " day and " + hoursleft + " hours", "OK");
                }
                else if (days == 1 && hoursleft < 1)
                {

                    await DisplayAlert("Result", "Battery will last approximately " + days + " day and " + hoursleft + " hour", "OK");
                }
                else if (days > 1 && hoursleft > 1)
                {

                    await DisplayAlert("Result", "Battery will last approximately " + days + " days and " + hoursleft + " hours", "OK");
                }
                else if (days > 1 && hoursleft <= 1)
                {

                    await DisplayAlert("Result", "Battery will last approximately " + days + " days and " + hoursleft + " hour", "OK");
                }

                else if (result <= 1)
                {
                    await DisplayAlert("Result", "Battery will last approximately " + result.ToString() + " hour", "OK");
                }

               // await Navigation.PushModalAsync(new ModalPage(), false);
            }
            catch (Exception)
            {

                await DisplayAlert("Error", "Error calculating. Please check the values you entered.", "OK");
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            int cap = 150;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            int cap = 100;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            int cap = 200;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            int cap = 300;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            int cap = 500;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            int cap = 1000;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            int cap = 2000;
            try
            {
                capacity.Text = (int.Parse(capacity.Text) + cap).ToString();
            }
            catch (Exception)
            {
                capacity.Text = cap.ToString();
            }
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            capacity.Text = "";
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
            voltage.Text = capacity.Text = loads.Text = "";

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
    }
}