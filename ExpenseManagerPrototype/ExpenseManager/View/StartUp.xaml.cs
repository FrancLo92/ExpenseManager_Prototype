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
    public partial class StartUp : ContentPage
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private async void loginSignupBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.LoginPage());
        }

        private void requestAppointmentBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RequestAppointment());
        }

        private void locateUsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocateUs());
        }
    }
}