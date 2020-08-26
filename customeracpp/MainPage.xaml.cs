using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace customeracpp
{
    public partial class MainPage : ContentPage
    {
        public class LoginResponse
        {
            public string urldata { get; set; }

        }
        LoginResponse ds = new LoginResponse();

        public MainPage()
        {
            InitializeComponent();
        }

        public void GetmapURL(string URL)
        {
            Application.Current.MainPage = new GuestPage(URL);

          //  ds.urldata = URL;
     
            //DisplayAlert("Message Recived", URL, "OK");
        }

        void showpath_Clicked(System.Object sender, System.EventArgs e)
        {
            string url = "https://travelupdates.abudhabiairport.ae/Wayfinder?lat=24.42922&long=54.64388&dest=B3-UL0-ID017&floor=Departure";
            Navigation.PushAsync(new GuestPage(url));
        }
    }
}
