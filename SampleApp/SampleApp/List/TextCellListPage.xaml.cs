using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleApp.List
{
    public partial class TextCellListPage : ContentPage
    {
        public TextCellListPage()
        {
            InitializeComponent();

            var products = new List<Product>
            {
                new Product { Name = "Kartu Halo", TelcoName="Telkomsel", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Product { Name = "Simpati", TelcoName="Telkomsel", ImageUrl="http://lorempixel.com/100/100/people/2" },
                new Product { Name = "Kartu As", TelcoName="Telkomsel", ImageUrl="http://lorempixel.com/100/100/people/3" },
                new Product { Name = "Loop", TelcoName="Telkomsel", ImageUrl="http://lorempixel.com/100/100/people/4" },
                new Product { Name = "Matrix", TelcoName="Indosat", ImageUrl="http://lorempixel.com/100/100/people/5" },
                new Product { Name = "IM3", TelcoName="Indosat", ImageUrl="http://lorempixel.com/100/100/people/6" },
                new Product { Name = "Mentari", TelcoName="Indosat", ImageUrl="http://lorempixel.com/100/100/people/7" },
                new Product { Name = "XL", TelcoName="XL", ImageUrl="http://lorempixel.com/100/100/people/8" },
                new Product { Name = "Tri", TelcoName="Hutchison", ImageUrl="http://lorempixel.com/100/100/people/9" },
                new Product { Name = "Smartfren", TelcoName="Smartfren", ImageUrl="http://lorempixel.com/100/100/people/10" }
            };

            listView.ItemsSource = products;
        }
    }
}
