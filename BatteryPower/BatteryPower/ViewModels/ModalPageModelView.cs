using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BatteryPower.ViewModels
{
    public class ModalPageModelView : BaseViewModel
    {
        public ModalPageModelView()
        {
            Title = "";
        }

        public string Loads { get; set; }
    }
}