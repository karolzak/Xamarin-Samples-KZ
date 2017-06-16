// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamNatMVVMCross.iOS
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton firstButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel xxxLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (firstButton != null) {
                firstButton.Dispose ();
                firstButton = null;
            }

            if (xxxLabel != null) {
                xxxLabel.Dispose ();
                xxxLabel = null;
            }
        }
    }
}