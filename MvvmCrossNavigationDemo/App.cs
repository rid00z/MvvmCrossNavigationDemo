using MvvmCross.Platform.IoC;

namespace MvvmCrossNavigationDemo.Core
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<ViewModels.FirstNativeViewModel>();
        }
    }
}