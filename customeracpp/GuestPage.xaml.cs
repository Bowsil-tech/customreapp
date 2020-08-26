using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace customeracpp
{
    public partial class GuestPage : ContentPage
    {
        public GuestPage()
        {
            InitializeComponent();
        }
        public GuestPage(string Url)
        {
            InitializeComponent();
            titlelbl.Text = Url;
        }

         void Button_Clicked(object sender, EventArgs e)
        {

            string url = titlelbl.Text.ToString().Replace("$lat", "24.42922").Replace("$long", "54.6438");
         //   var disp = new MapView(titlelbl.Text);
            Uri uri = new Uri(url);

            _ = OpenBrowser(uri);
             //Navigation.PushAsync(disp);
        }

        void AlertAgent(object sender, EventArgs e)
        {

            DisplayAlert("Notified Agent", "Your Location has been shared with Eithad Guest Service", "OK");
        }

        public async Task OpenBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.AliceBlue,
                PreferredControlColor = Color.Violet
            });
        }
    }
}
