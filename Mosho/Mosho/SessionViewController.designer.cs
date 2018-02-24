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
    [Register ("SessionViewController")]
    partial class SessionViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView liveCameraStream { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView SampleFace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ScoreLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView SimilarityBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SwitchCameraButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TakePhotoButton { get; set; }

        [Action ("SwitchCameraButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SwitchCameraButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("TakePhotoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TakePhotoButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (liveCameraStream != null) {
                liveCameraStream.Dispose ();
                liveCameraStream = null;
            }

            if (SampleFace != null) {
                SampleFace.Dispose ();
                SampleFace = null;
            }

            if (ScoreLabel != null) {
                ScoreLabel.Dispose ();
                ScoreLabel = null;
            }

            if (SimilarityBar != null) {
                SimilarityBar.Dispose ();
                SimilarityBar = null;
            }

            if (SwitchCameraButton != null) {
                SwitchCameraButton.Dispose ();
                SwitchCameraButton = null;
            }

            if (TakePhotoButton != null) {
                TakePhotoButton.Dispose ();
                TakePhotoButton = null;
            }
        }
    }
}