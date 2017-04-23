using System;
using Foundation;
using MvvmCross.iOS.Views;
using CoreGraphics;
using UIKit;
using MvvmCross.Binding.BindingContext;
using ObjCRuntime;

namespace MvvmCrossNavigationDemo.iOS.Views
{
	[Register("FirstNativeView")]
	public class FirstNativeView : MvxViewController
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
			var button = new UIButton (new CGRect (10, 100, 300, 40));
			button.SetTitle ("Move to next", UIControlState.Normal);
			button.SetTitleColor (UIColor.Blue, UIControlState.Normal);
			Add (button);

			var set = this.CreateBindingSet<FirstNativeView, Core.ViewModels.FirstNativeViewModel>();
			set.Bind(label).To(vm => vm.PageContent);
			set.Bind(button).To(vm => vm.MoveToNext);
			set.Apply();
		}
	}
}
