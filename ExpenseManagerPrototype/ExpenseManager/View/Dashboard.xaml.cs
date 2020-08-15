﻿using System;
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

        private async void recordGpsTripBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GPSTrip());
        }

        private async void scanReceiptBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Receipt());
        }
    }
}