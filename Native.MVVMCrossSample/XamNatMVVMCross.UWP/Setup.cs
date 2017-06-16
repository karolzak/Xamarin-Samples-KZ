using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using MvvmCross.Uwp.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace XamNatMVVMCross.UWP
{
    //SHOW Mvx - Windows setup
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        
        protected override void InitializeFirstChance()
        {

            base.InitializeFirstChance();

            //SHOW IDialogService - register custom Windows implementation
            //register platform specific implementations
            //example:
            //Mvx.RegisterSingleton<IScreenSize>(new WindowsPhoneScreenSize());
        }
        protected override IMvxApplication CreateApp()
        {
            //start the App
            return new XamNatMVVMCross.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override IMvxIoCProvider CreateIocProvider()
        {
            
            return base.CreateIocProvider();
        }
    }
}
