using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmCrossNavigationDemo.Core.ViewModels
{
	public class ThirdNativeViewModel: MvxViewModel
	{
		public ThirdNativeViewModel ()
		{
		}

		public string PageContent { 
			get {
				return "This is a Native Page, 3 of 3";
			}
		}


		public MvxCommand MoveToFront {
			get {

				return new MvxCommand (() => {
					ChangePresentation(new MvxClosePresentationHint(this));
				});
			}
		} 

        public MvxCommand MoveToNext {
            get {

                return new MvxCommand (() => {
                    ShowViewModel<FirstNativeViewModel>();
                });
            }
        } 
	}
}

