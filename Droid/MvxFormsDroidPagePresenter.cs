using System;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using MvvmCrossNavigationDemo.Core;
using Android.App;
using Cirrious.MvvmCross.Views;
using Cirrious.CrossCore;
using Android.Content;

namespace MvvmCrossNavigationDemo.Droid
{
    public class MvxFormsDroidPagePresenter : MvxAndroidViewPresenter, IMvxAndroidViewPresenter
    {
        public MvxFormsDroidPagePresenter ()
        {
        }

        public override void ChangePresentation (MvxPresentationHint hint)
        {
            if (hint is MvxClosePresentationHint) {
                var viewModel = (hint as MvxClosePresentationHint).ViewModelToClose;

                Activity activity = this.Activity;

                IMvxView mvxView = activity as IMvxView;

                activity.Finish ();

                return;
            }                
        }

        public override void Show (MvxViewModelRequest request)
        {
            //detect if we want a Forms View 
            if (request.ViewModelType.FullName.Contains ("XFViewModel")) {
                //get the Forms page from the request 
                var contentPage = MvxPresenterHelpers.CreatePage (request);

                //set DataContext of page to LoadViewModel
                var viewModel = MvxPresenterHelpers.LoadViewModel (request);

                //set the binding context of the content page
                contentPage.BindingContext = viewModel;

                //set the current page of the activity 
                MvxFormsApplicationActivity.CurrentPage = contentPage;

                //Start the Xamarin.Forms Activity
                Activity.StartActivity (typeof(MvxFormsApplicationActivity));

            } else {
                base.Show (request);
            }
        }
    }

}

