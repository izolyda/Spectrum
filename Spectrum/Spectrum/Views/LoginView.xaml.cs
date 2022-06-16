using System;
using System.Collections.Generic;
using Spectrum.Droid.Helpers;
using Xamarin.Forms;

namespace Spectrum.Views
{	
	public partial class LoginView : ContentPage
	{	
		public LoginView ()
		{
			InitializeComponent ();
			switch (Device.RuntimePlatform)
			{
				case Device.Android:
					Image imgCameraBtn = new Image
					{
						Source = "camera.png",
						VerticalOptions = LayoutOptions.EndAndExpand,
						HorizontalOptions = LayoutOptions.Center,
						HeightRequest = 100,
						WidthRequest = 100
					};

					var tapGestureRecognizer = new TapGestureRecognizer();

					tapGestureRecognizer.Tapped += OnButtonClicked;

					imgCameraBtn.GestureRecognizers.Add(tapGestureRecognizer);

					stackLayoutWelcome.Children.Add(imgCameraBtn);

					break;
			}
		}

        private void OnButtonClicked(object sender, EventArgs e)
        {
			DependencyService.Register<INativePages>();
			DependencyService.Get<INativePages>().StartActivityInAndroid();
		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new CategoriesView());
			
		}

    }
}

