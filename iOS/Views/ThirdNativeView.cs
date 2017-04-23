using System;
using Foundation;
using MvvmCross.iOS.Views;
using CoreGraphics;
using UIKit;
using MvvmCross.Binding.BindingContext;
using ObjCRuntime;


namespace MvvmCrossNavigationDemo.iOS.Views
{
	[Register("ThirdNativeView")]
	public class ThirdNativeView : MvxViewController
	{
		public override void ViewDidLoad()
		{
			View = new UIView { BackgroundColor = UIColor.White };
			base.ViewDidLoad();

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
			{
				EdgesForExtendedLayout = UIRectEdge.None;
			}

			var label = new UILabel(new CGRect(10, 10, 300, 40));
			Add(label);

			var set = this.CreateBindingSet<ThirdNativeView, Core.ViewModels.ThirdNativeViewModel>();
			set.Bind(label).To(vm => vm.PageContent);
			set.Apply();
		}
	}
}


