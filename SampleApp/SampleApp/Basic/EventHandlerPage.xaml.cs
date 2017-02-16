using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleApp.Basic
{
    public partial class EventHandlerPage : ContentPage
    {
        public EventHandlerPage()
        {
            InitializeComponent();

            // initial value for the slider
            slider.Value = (slider.Minimum + slider.Maximum) / 2;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Greetings", "Welcome to Xamarin Forms!", "Close");
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var value = e.NewValue;

            // set the label with value from slider
            label.Text = String.Format("The value is: {0:F2}", value);
        }
    }
}
