using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseManager.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleDetails : ContentPage
    {
        public VehicleDetails()
        {
            InitializeComponent();
        }

        private async void saveVehicle_Clicked(object sender, EventArgs e)

        {
            await Navigation.PopToRootAsync();
        }

        private async void deleteVehicleBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}