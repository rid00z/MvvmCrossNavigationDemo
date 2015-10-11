using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmCrossNavigationDemo.Core.ViewModels
{
	public class SecondXFViewModel : MvxViewModel
	{
		public SecondXFViewModel ()
		{
		}

		public string PageContent { 
			get {
				return "This is a Xamarin Forms Page, 2 of 3";
			}
		}

		public MvxCommand MoveToNext
		{
			get {
				return new MvxCommand (()=>{
					this.ShowViewModel<ThirdNativeViewModel>();
				});
			}
		}

		public MvxCommand MoveToFront
		{
			get {
				return new MvxCommand (()=>{
					ChangePresentation(new MvxClosePresentationHint(this));
				});
			}
		}
	}
}

