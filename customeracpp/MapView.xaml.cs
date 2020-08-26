using System;
using System.Collections.Generic;
using Xam.Plugin.WebView.Abstractions;
using Xamarin.Forms;

namespace customeracpp
{
    public partial class MapView : ContentPage
    {
        public MapView()
        {
            InitializeComponent();
        }
        public MapView(string url)
        {

            InitializeComponent();
            interneview.Source= @"https://travelupdates.abudhabiairport.ae/Wayfinder?lat=24.42922&long=54.64388&dest=B3-UL0-ID017&floor=Departure";

            //    internetContent.Source = @"https://travelupdates.abudhabiairport.ae/Wayfinder?lat=24.42922&long=54.64388&dest=B3-UL0-ID017&floor=Departure";

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.9, 900, Easing.SpringIn);
        }

        protected void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        protected void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }
    }
}
