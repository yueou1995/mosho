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
        }
    }
}