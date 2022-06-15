using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Spectrum.Views
{	
	public partial class LoginView : ContentPage
	{	
		public LoginView ()
		{
			InitializeComponent ();
		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new CategoriesView());
			
		}

    }
}

