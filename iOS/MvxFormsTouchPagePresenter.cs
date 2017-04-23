using System;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;
using UIKit;
using MvvmCrossNavigationDemo.Core;

namespace MvvmCrossNavigationDemo.iOS
{
    public class MvxFormsTouchPagePresenter : MvxIosViewPresenter
    {
    	public MvxFormsTouchPagePresenter (IUIApplicationDelegate applicationDelegate, UIWindow window) : base (applicationDelegate, window)
    	{
    	}

    	public override void ChangePresentation (MvxPresentationHint hint)
    	{
    		this.MasterNavigationController.PopViewController (true);
    	}

    	public override void Show (MvxViewModelRequest request)
    	{
            // XFViewModel means we need a Forms View
            if (request.ViewModelType.FullName.Contains ("XFViewModel")) 
            {
                //get the xamarin.forms page from the ViewModel
                var contentPage = MvxPresenterHelpers.CreatePage (request); 

                //MvvmCross call to create the view model with DI etc
                var viewModel = MvxPresenterHelpers.LoadViewModel (request); 

                //Assign it to the Forms Binding Content
                contentPage.BindingContext = viewModel;				

                //Creating the view controller from the content page
                var viewController = contentPage.CreateViewController ();
				viewController.Title = contentPage.Title;

                if (this.MasterNavigationController == null) 
                {
                    // If it's the first view 
                    this.ShowFirstView (viewController);
                } 
                else 
                {
                    // If it's already in the stack
                    this.MasterNavigationController.PushViewController (viewController, true);
                }

            } 
            else 
            {
                //Using a normal MvvmCross View
                base.Show (request);
            }
    	}
    }
}

