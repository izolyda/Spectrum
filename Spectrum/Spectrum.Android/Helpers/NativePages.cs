using System;
using Spectrum.Droid.Helpers;
using Xamarin.Forms;
using Spectrum.Droid.Activities;
using Android.Content;

[assembly: Dependency(typeof(NativePages))]
namespace Spectrum.Droid.Helpers
{
    public class NativePages : INativePages
    {
        public NativePages()
        {
        }


        public void StartActivityInAndroid()
        {
            var intent = new Intent(Forms.Context, typeof(CameraActivity));
            Forms.Context.StartActivity(intent);
        }
    }
}

