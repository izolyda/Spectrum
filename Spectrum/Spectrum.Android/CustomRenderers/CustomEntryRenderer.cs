using System;
using Android.Content;
using Spectrum.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace Spectrum.Droid.CustomRenderers
{
	public class CustomEntryRenderer: EntryRenderer
	{
		public CustomEntryRenderer(Context context): base(context)
		{
		}

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;


            Control.Background = Context.GetDrawable(Resource.Drawable.custom_rect);


        }
    }
}

