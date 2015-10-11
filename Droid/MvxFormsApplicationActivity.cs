using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmCrossNavigationDemo.Droid
{
    [Activity (Label = "XamarinForm", Theme = "@android:style/Theme.Holo.Light", NoHistory = false)]
    public class MvxFormsApplicationActivity : FormsApplicationActivity
    {
        public static Page CurrentPage;

        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            Forms.Init (this, bundle);

            SetPage (CurrentPage);

            var lifetimeMonitor = Mvx.Resolve<IMvxAndroidCurrentTopActivity> () as MvxAndroidLifetimeMonitor;
            lifetimeMonitor.OnCreate (this);
        }

        protected override void OnStart ()
        {
            base.OnStart ();
            var lifetimeMonitor = Mvx.Resolve<IMvxAndroidCurrentTopActivity> () as MvxAndroidLifetimeMonitor;
            lifetimeMonitor.OnStart (this);
        }

        protected override void OnRestart ()
        {
            base.OnRestart ();
            var lifetimeMonitor = Mvx.Resolve<IMvxAndroidCurrentTopActivity> () as MvxAndroidLifetimeMonitor;
            lifetimeMonitor.OnRestart (this);
        }

        protected override void OnResume ()
        {
            base.OnResume ();
            var lifetimeMonitor = Mvx.Resolve<IMvxAndroidCurrentTopActivity> () as MvxAndroidLifetimeMonitor;
            lifetimeMonitor.OnResume (this);
        }

        protected override void OnDestroy ()
        {
            base.OnDestroy ();
            var lifetimeMonitor = Mvx.Resolve<IMvxAndroidCurrentTopActivity> () as MvxAndroidLifetimeMonitor;
            lifetimeMonitor.OnDestroy (this);
        }
    }
}

