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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void signUpBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }

        private async void cancelSignUpBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }

        
    }
}