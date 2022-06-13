using System;
using System.Collections.Generic;
using Spectrum.Models;
using Xamarin.Forms;

namespace Spectrum.Views
{	
	public partial class MainView : ContentPage
	{
        List<News> news;
        RSSFeedReader reader = new RSSFeedReader();

        public MainView ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            news = await reader.readRSS("https://hnrss.org/newest");
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new NewsFeedView());
        }
    }
}

