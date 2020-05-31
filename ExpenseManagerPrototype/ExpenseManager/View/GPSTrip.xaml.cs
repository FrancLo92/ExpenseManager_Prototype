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
    public partial class GPSTrip : ContentPage
    {
        public GPSTrip()
        {
            InitializeComponent();
        }

        private async void completeTripBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TripDetails());
        }

        private async void cancelTripBtn_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();
        }
    }
}