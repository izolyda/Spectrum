using System;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Spectrum.Droid.Effects.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Spectrum")]
[assembly: ExportEffect(typeof(AndroidOutlineEffect), "OutlineEffect")]
namespace Spectrum.Droid.Effects.Droid
{
	public class AndroidOutlineEffect : PlatformEffect
	{
		public AndroidOutlineEffect()
		{
		}

        protected override void OnAttached()
        {

            GradientDrawable shape = new GradientDrawable();
            shape.SetCornerRadii(new float[] { 20, 20, 0, 0, 20, 20, 0, 0 });
            shape.SetColor(Android.Graphics.Color.SeaGreen);
            shape.SetStroke(3, Android.Graphics.Color.Black);
            Control.Background = shape;

        }


        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }


    }
}

