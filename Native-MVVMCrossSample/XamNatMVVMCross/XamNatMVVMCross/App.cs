using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.IoC;
using XamNatMVVMCross.ViewModels;

namespace XamNatMVVMCross
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            //SHOW: Registering services as singeltons
            //search for all classes (ending with 'Service') and register them as LazySingleton
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            // register the appstart object
            RegisterAppStart<FirstViewModel>();
        }


    }
}
