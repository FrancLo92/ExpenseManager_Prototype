using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpenseManager.Model;

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

        private async void recordGpsTripBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GPSTrip());
        }

        private async void scanReceiptBtn_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg",
                SaveToAlbum = true,
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front
            });

            if (file == null)
                return;

            //await DisplayAlert("File Location", file.Path, "OK");

            

            Model.Receipt receipt = new Model.Receipt();

            receipt.receiptImg = new Image();

            receipt.receiptImg.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

            receipt.Total = 330;

            // Creating a new instance of Receipt details page.
            // Assigning the receipt object with the receipt image 
            // to the page's bindinding context.
            // Finally we call the PushAsync method and we pass the 
            // page we just created as a parameter.

            var receiptDetailsPage = new ReceiptDetails();
            receiptDetailsPage.BindingContext = receipt;

            await Navigation.PushAsync(receiptDetailsPage );
        }


    }
}