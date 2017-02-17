using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleApp.List
{
    public partial class BasicListPage : ContentPage
    {
        public BasicListPage()
        {
            InitializeComponent();

            var names = new List<String>
            {
                "Kartu Halo",
                "Simpati",
                "Kartu As",
                "Loop",
                "Matrix",
                "IM3",
                "Mentari",
                "XL",
                "Tri",
                "SmartFren"
            };

            listView.ItemsSource = names;
        }
    }
}
