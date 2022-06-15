using System;
using System.Collections.Generic;
using System.Threading;
using Spectrum.Data;
using Spectrum.Models;
using Spectrum.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spectrum
{
    public partial class App : Application
    {

        public App ()
        {
           
            InitializeComponent();

        
            MainPage = new NavigationPage(new LoginView());
       
        }

        protected override void OnStart ()
        {
           
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

      
    }
}

