using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmCrossNavigationDemo.Core.ViewModels
{
	public class FirstNativeViewModel: MvxViewModel
	{
		public FirstNativeViewModel ()
		{
		}

		public string PageContent { 
			get {
				return "This is a Native Page, 1 of 3";
			}
		}

		public MvxCommand MoveToNext
		{
			get {
				return new MvxCommand (()=>{					
                    ShowViewModel<SecondXamarinViewModel>();
				});
			}
		}
	}
}

