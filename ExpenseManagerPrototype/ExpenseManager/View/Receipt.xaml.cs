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
    public partial class Receipt : ContentPage
    {
        public IList<Model.Receipt> ReceiptList { get; set; }

        public Receipt()
        {
            InitializeComponent();
            loadData();
            BindingContext = this;
        }

        // Receipt List Item Selected Event
        private async void receiptListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ReceiptDetails());
        }

        // Add manual Receipt clicke event
        private async void addManualReceipt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReceiptDetails());
        }

        // this methods adds test data for the vehicle list
        public void loadData()
        {
            ReceiptList = new List<Model.Receipt>();

            Model.Receipt r1 = new Model.Receipt
            {
                Total = 150,
                Tax = 15,
                ABN = "025478669785",
                Date = "20/08/20",
                Merchant = "Bunnings"
            };

            Model.Receipt r2 = new Model.Receipt
            {
                Total = 200,
                Tax = 20,
                ABN = "025478779785",
                Date = "17/08/20",
                Merchant = "Mitre 10"
            };

            Model.Receipt r3 = new Model.Receipt
            {
                Total = 70,
                Tax = 7,
                ABN = "025478669785",
                Date = "18/08/20",
                Merchant = "OTR"
            };

            ReceiptList.Add(r1);
            ReceiptList.Add(r2);
            ReceiptList.Add(r3);
        }

        
    }
}