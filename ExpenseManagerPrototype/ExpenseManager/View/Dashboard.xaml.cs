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
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void requestAppointmentBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RequestAppointment());            
        }

        private async void locateUsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocateUs());            
        }

        private void logOutBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new StartUp());
        }
    }
}