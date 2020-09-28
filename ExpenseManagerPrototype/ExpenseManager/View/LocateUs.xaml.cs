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
    public partial class LocateUs : ContentPage
    {
        public LocateUs()
        {
            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://thekalculators.com.au/locations/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Accomodate iPhone status bar.
            //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };
        }
    }
}