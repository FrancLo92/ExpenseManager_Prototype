using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExpenseManager.Model
{
    public class Receipt
    {
        public double Total { get; set; }
        public double Tax { get; set; }
        public string ABN { get; set; }
        public string Date { get; set; }

        public Image receiptImg { get; set; }

        public string Merchant { get; set; }
    }
}
