using System;
using Android.Content;
using Spectrum.Droid.CustomRenderers;
using Spectrum.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]

namespace Spectrum.Droid.CustomRenderers
{
	public class CustomLabelRenderer : LabelRenderer
	{
		public CustomLabelRenderer(Context context): base(context)
		{
		}

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var el = Element as CustomLabel;

            if (el != null && el.JustifyText)
            {
                if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
                {
                    Control.JustificationMode = Android.Text.JustificationMode.InterWord;
                }

            }
        }
    }

   
}

