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
    public partial class Profile1 : ContentPage
    {
        public Profile1()
        {
            InitializeComponent();
        }

        private async void ChangePasswordBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePassword());
        }
        private async void SignOutBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignOut());
        }
    }
}