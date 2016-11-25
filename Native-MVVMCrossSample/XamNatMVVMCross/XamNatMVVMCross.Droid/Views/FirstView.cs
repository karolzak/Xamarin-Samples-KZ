using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamNatMVVMCross.Droid.Views
{
	[Activity (Label = "XamNatMVVMCross.Droid",  Icon = "@drawable/icon")]
	public class FirstView : MvvmCross.Droid.Views.MvxActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.First);
        }
	}
}


