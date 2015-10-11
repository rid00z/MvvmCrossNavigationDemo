using System;
using Cirrious.MvvmCross.ViewModels;
using Xamarin.Forms;
using Cirrious.CrossCore;
using System.Reflection;
using Cirrious.CrossCore.IoC;
using System.Linq;

namespace MvvmCrossNavigationDemo.Core
{
    public static class MvxPresenterHelpers
    {
        /// <summary>
        /// Creates a view model from a view model request
        /// </summary>
        public static IMvxViewModel LoadViewModel (MvxViewModelRequest request)
        {
            var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader> ();
            var viewModel = viewModelLoader.LoadViewModel (request, null);
            return viewModel;
        }

        /// <summary>
        /// Create a Xamarin.Forms page from a View Model request
        /// </summary>
        public static Page CreatePage (MvxViewModelRequest request)
        {
            var viewModelName = request.ViewModelType.Name;
            var pageName = viewModelName.Replace ("XFViewModel", "Page");
            var pageType = request.ViewModelType.GetTypeInfo ().Assembly.CreatableTypes ()
				.FirstOrDefault (t => t.Name == pageName);
            if (pageType == null) {
                Mvx.Trace ("Page not found for {0}", pageName);
                return null;
            }

            var page = Activator.CreateInstance (pageType) as Page;
            if (page == null) {
                Mvx.Error ("Failed to create ContentPage {0}", pageName);
            }
            return page;
        }
    }
}

