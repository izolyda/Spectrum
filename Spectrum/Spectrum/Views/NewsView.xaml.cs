using System;
using System.Collections.Generic;
using Spectrum.Models;
using Xamarin.Forms;

namespace Spectrum.Views
{	
	public partial class NewsView : ContentPage
	{	
		public NewsView (News news)
		{
			InitializeComponent ();

			this.BindingContext = news;
		}

        void WebView_Navigating(System.Object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            activityIndicator.IsRunning = true;
        }

        void WebView_Navigated(System.Object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            activityIndicator.IsRunning = false;
        }
    }
}

