
using System;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Widget;

namespace Spectrum.Droid.Activities
{
	[Activity (Label = "CameraActivity")]			
	public class CameraActivity : Activity
	{
		ImageView imageView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView(Resource.Layout.CameraLayout);
			var btnCamera = FindViewById<Button>(Resource.Id.btnCamera);
			imageView = FindViewById<ImageView>(Resource.Id.imgView);
			btnCamera.Click += BtnCamera_Click;
		}

		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
            try
            {
				Bitmap bitmap = (Bitmap)data.Extras.Get("data");
				imageView.SetImageBitmap(bitmap);
			} catch(Exception ex)
            {
				Console.WriteLine(ex);
				return;
            }
			
		}

		private void BtnCamera_Click(object sender, System.EventArgs e)
		{
			Intent intent = new Intent(MediaStore.ActionImageCapture);
			StartActivityForResult(intent, 0);
		}
	}
}

