using System;

using Xamarin.Forms;
using System.Threading.Tasks;
#if __ANDROID__
using Xamarin.Forms.Platform.Android;
using Forms_NativeEmbedding.Droid;
using Android.Views;
#elif __IOS__
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;
#elif UWP
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;
#endif

namespace Forms_NativeEmbedding
{
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			
			InitializeComponent ();


			//var pageLayout = this.FindByName<StackLayout>("pageLayout");
			//var absolute = this.FindByName<AbsoluteLayout>("absolute");
			//var list = this.FindByName<Xamarin.Forms.ListView>("list");
			absolute.VerticalOptions = LayoutOptions.FillAndExpand;
				absolute.HorizontalOptions = LayoutOptions.FillAndExpand;
			AbsoluteLayout.SetLayoutFlags(pageLayout, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(pageLayout, new Rectangle(0f, 0f, 1f, 1f));
			list.ItemsSource = new[] { "Hello", "World", "This", "Is", "Native", "Embedding" };
			var stack = new StackLayout
			{
				Padding = 8,
				HorizontalOptions = LayoutOptions.Center,
			};




#if __ANDROID__
			var fab = new CheckableFab(Forms.Context);
		   
			fab.SetImageResource(Droid.Resource.Drawable.ic_fancy_fab_icon);
			fab.Click += async (sender, e) =>
			{
				await Task.Delay(3000);
				await this.DisplayAlert("Native FAB Clicked", 
											"Whoa!!!!!!", "OK");
			};


			fab.UseCompatPadding = true;
			stack.Children.Add(fab);
			absolute.Children.Add(stack);
			// Overlay the FAB in the bottom-right corner
			AbsoluteLayout.SetLayoutFlags(stack, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(stack, new Rectangle(1f, 1f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

#elif __IOS__
			var segmentControl = new UISegmentedControl();
			segmentControl.Frame = new CGRect(20, 20, 280, 40);
			segmentControl.InsertSegment("One", 0, false);
			segmentControl.InsertSegment("Two", 1, false);
			segmentControl.SelectedSegment = 1;
			segmentControl.ValueChanged += async (sender, e) =>
			{
				var selectedSegmentId = (sender as UISegmentedControl).SelectedSegment;
				await this.DisplayAlert($"Native Segmented Control Clicked {selectedSegmentId}","Whoa!!!!!!", "OK");
			};
			stack.Children.Add(segmentControl);
			pageLayout.Children.Insert(0, stack);
#elif UWP
			var calendar = new CalendarView();
			stack.Children.Add(calendar);
			pageLayout.Children.Insert(0, stack);
#endif

		}
	}
}
