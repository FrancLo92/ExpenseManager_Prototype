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
    public partial class ChangePassword : ContentPage
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

       
        private async void cancelChangePaswdBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }

        private async void saveNewPaswdBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());
        }
    }
}