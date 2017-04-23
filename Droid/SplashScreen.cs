using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using Xamarin.Forms;

namespace MvvmCrossNavigationDemo.Droid
{
    [Activity(
		Label = "MvvmCrossNavigationDemo.Droid"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

		protected override void OnCreate (Android.OS.Bundle bundle)
		{
			base.OnCreate (bundle);
			Forms.Init(this, bundle);
		}
    }
}