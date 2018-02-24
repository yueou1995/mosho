using System;

using UIKit;

namespace Mosho
{
    public partial class SelectionViewController : UIViewController
    {
        protected SelectionViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void TBDButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.TBD;
        }

        partial void FearButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.Fear;
        }

        partial void CalmButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.Calm;
        }

        partial void AngryButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.Angry;
        }

        partial void SadButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.Sad;
        }

        partial void HappyButton_TouchUpInside(UIButton sender)
        {
            SessionViewController.Emotion = Emotion.Happy;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
