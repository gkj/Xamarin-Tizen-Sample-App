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

            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Greetings", "Welcome to Xamarin Forms!", "Close");
        }
    }
}
