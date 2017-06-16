using Foundation;
using System;
using MvvmCross.iOS.Views;
using XamNatMVVMCross.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace XamNatMVVMCross.iOS
{
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView () : base ("FirstView", null)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var set = this.CreateBindingSet<FirstView, FirstViewModel>();

            //set.Bind(firstButton).For(first=>first.TitleLabel).To((FirstViewModel vm) => vm.ButtonText).Apply();
            //set.Bind(firstButton).To((FirstViewModel vm) => vm.IncCommand).Apply();
        }


    }
}