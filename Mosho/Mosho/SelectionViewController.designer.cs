// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mosho
{
    [Register ("SelectionViewController")]
    partial class SelectionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AngryButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalmButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HappyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SadButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TBDButton { get; set; }

        [Action ("AngryButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AngryButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CalmButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CalmButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("FearButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FearButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("HappyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HappyButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("SadButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SadButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("TBDButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TBDButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AngryButton != null) {
                AngryButton.Dispose ();
                AngryButton = null;
            }

            if (CalmButton != null) {
                CalmButton.Dispose ();
                CalmButton = null;
            }

            if (FearButton != null) {
                FearButton.Dispose ();
                FearButton = null;
            }

            if (HappyButton != null) {
                HappyButton.Dispose ();
                HappyButton = null;
            }

            if (SadButton != null) {
                SadButton.Dispose ();
                SadButton = null;
            }

            if (TBDButton != null) {
                TBDButton.Dispose ();
                TBDButton = null;
            }
        }
    }
}