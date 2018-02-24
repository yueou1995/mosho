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
        UIKit.UIImageView AngryIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalmButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView CalmIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DisgustButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView DisgustIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView FearIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HappyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HappyIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SadButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SadIcon { get; set; }

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

            if (AngryIcon != null) {
                AngryIcon.Dispose ();
                AngryIcon = null;
            }

            if (CalmButton != null) {
                CalmButton.Dispose ();
                CalmButton = null;
            }

            if (CalmIcon != null) {
                CalmIcon.Dispose ();
                CalmIcon = null;
            }

            if (DisgustButton != null) {
                DisgustButton.Dispose ();
                DisgustButton = null;
            }

            if (DisgustIcon != null) {
                DisgustIcon.Dispose ();
                DisgustIcon = null;
            }

            if (FearButton != null) {
                FearButton.Dispose ();
                FearButton = null;
            }

            if (FearIcon != null) {
                FearIcon.Dispose ();
                FearIcon = null;
            }

            if (HappyButton != null) {
                HappyButton.Dispose ();
                HappyButton = null;
            }

            if (HappyIcon != null) {
                HappyIcon.Dispose ();
                HappyIcon = null;
            }

            if (SadButton != null) {
                SadButton.Dispose ();
                SadButton = null;
            }

            if (SadIcon != null) {
                SadIcon.Dispose ();
                SadIcon = null;
            }
        }
    }
}