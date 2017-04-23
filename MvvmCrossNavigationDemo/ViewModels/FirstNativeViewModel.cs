﻿using System;
using MvvmCross.Core.ViewModels;

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

        public MvxCommand MoveToFront {
            get {

                return new MvxCommand (() => {
                    ChangePresentation(new MvxClosePresentationHint(this));
                });
            }
        } 

		public MvxCommand MoveToNext
		{
			get {
				return new MvxCommand (()=>{					
                    ShowViewModel<SecondXFViewModel>();
				});
			}
		}
	}
}

