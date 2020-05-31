using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpenseManager.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleLogbook : ContentPage
    {
        public IList<Vehicle> VehicleList { get; set; }

        public IList<Trip> TripList { get; set; }

        public VehicleLogbook()
        {
            InitializeComponent();
            loadData();
            BindingContext = this;
            
        }

        
        // this methods adds test data for the vehicle list
        public void loadData()
        {

            DateTime date1 = DateTime.Now.Date;
            VehicleList = new List<Vehicle>();

            Vehicle v1 = new Vehicle
            {
                numberPlate = "AA456J",
                make = "Toyota",
                model = "Celica"
            };

            Vehicle v2 = new Vehicle
            {
                numberPlate = "BB847K",
                make = "Nissan",
                model = "Skyline"
            };

            Vehicle v3 = new Vehicle
            {
                numberPlate = "VV478L",
                make = "Holden",
                model = "Commodore"
            };

            vehicleListView.SelectedItem = v1;

            VehicleList.Add(v1);
            VehicleList.Add(v2);
            VehicleList.Add(v3);

            TripList = new List<Trip>();

            Trip t1 = new Trip
            {
                destination = "Adelaide City",
                from = "Campbelltown",
                km = 20,
                date = date1.Date.ToString("dd/MM/yyyy")
            };

            Trip t2 = new Trip
            {
                destination = "Gilles Plain",
                from = "Holden Hill",
                km = 3,
                date = date1.Date.ToString("dd/MM/yyyy")
            };

            Trip t3 = new Trip
            {
                destination = "North Adelaide",
                from = "Para Vista",
                km = 10,
                date = date1.Date.ToString("dd/MM/yyyy")
            };

            TripList.Add(t1);
            TripList.Add(t2);
            TripList.Add(t3);

        }

        private void vehicleListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Vehicle v = new Vehicle();
            v = (Vehicle)vehicleListView.SelectedItem;

            makeTxt.Text = v.make;
            modelTxt.Text = v.model;
            numPlateTxt.Text = v.numberPlate;
        }

        //This event hides/shows the vehicle list
        private void selectVehicleBtn_Clicked(object sender, EventArgs e)
        {
            if (vehicleListOuterContainer.IsVisible == true)
            {
                vehicleListOuterContainer.IsVisible = false;
                selectVehicleBtn.Text = "SELECT VEHICLE ﹀";
            }                
            else if (vehicleListOuterContainer.IsVisible == false)
            {
                vehicleListOuterContainer.IsVisible = true;
                selectVehicleBtn.Text = "SELECT VEHICLE ︿";
            }
                 
        }

        private async void tripListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new TripDetails());
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GPSTrip());
        }

        private async void addVehicle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VehicleDetails());
        }

        private async void editVehiclebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VehicleDetails());
        }
    }
}