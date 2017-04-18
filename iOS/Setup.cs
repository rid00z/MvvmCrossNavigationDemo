using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using MvvmCross.iOS.Views.Presenters;
using Xamarin.Forms;
using MvvmCross.Platform.Platform;

namespace MvvmCrossNavigationDemo.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IMvxIosViewPresenter CreatePresenter ()
		{
			Forms.Init ();
			return new MvxFormsTouchPagePresenter (ApplicationDelegate ,Window);
		}
	}
}