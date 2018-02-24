using Foundation;
using System;
using UIKit;
using AVFoundation;

namespace Mosho
{
    public partial class SessionViewController : UIViewController
    {
        public static Emotion Emotion { get; set; }

        AVCaptureSession captureSession;
        AVCaptureDeviceInput captureDeviceInput;
        AVCaptureStillImageOutput stillImageOutput;

        public SessionViewController (IntPtr handle) : base (handle)
        {
        
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DisplaySampleFace();
            SimilarityBar.Progress = 0f;

            // Perform any additional setup after loading the view, typically from a nib.

            AuthorizeCameraUse();
            SetupLiveCameraStream();
            UpdateScore();

        }

        private async void UpdateScore() {
            ScoreLabel.Text = (await ImageAnalyzer.Analyze(Emotion.Sad)).ToString();
        }

        private void DisplaySampleFace() {
            switch (Emotion) {
                case Emotion.Happy:
                    SampleFace.Image = UIImage.FromBundle("HappyBoy.jpg");
                    break;
                case Emotion.Sad:
                    SampleFace.Image = UIImage.FromBundle("SadBoy.jpg");
                    break;
                case Emotion.Fear:
                    SampleFace.Image = UIImage.FromBundle("FearBoy.jpg");
                    break;
                case Emotion.Angry:
                    SampleFace.Image = UIImage.FromBundle("AngryBoy.jpg");
                    break;
                case Emotion.Calm:
                    SampleFace.Image = UIImage.FromBundle("CalmBoy.jpg");
                    break;
                default:
                    SampleFace.Image = UIImage.FromBundle("TBD.jpg");
                    break;
            }
        }

        async void AuthorizeCameraUse()
        {
            var authorizationStatus = AVCaptureDevice.GetAuthorizationStatus(AVMediaType.Video);

            if (authorizationStatus != AVAuthorizationStatus.Authorized)
            {
                await AVCaptureDevice.RequestAccessForMediaTypeAsync(AVMediaType.Video);
            }
        }

        public void SetupLiveCameraStream()
        {
            captureSession = new AVCaptureSession();

            var viewLayer = liveCameraStream.Layer;
            var videoPreviewLayer = new AVCaptureVideoPreviewLayer(captureSession)
            {
                Frame = this.View.Frame
            };
            liveCameraStream.Layer.AddSublayer(videoPreviewLayer);

            var captureDevice = AVCaptureDevice.GetDefaultDevice(AVMediaType.Video);
            ConfigureCameraForDevice(captureDevice);
            captureDeviceInput = AVCaptureDeviceInput.FromDevice(captureDevice);
            captureSession.AddInput(captureDeviceInput);

            var dictionary = new NSMutableDictionary();
            dictionary[AVVideo.CodecKey] = new NSNumber((int)AVVideoCodec.JPEG);
            stillImageOutput = new AVCaptureStillImageOutput()
            {
                OutputSettings = new NSDictionary()
            };

            captureSession.AddOutput(stillImageOutput);
            captureSession.StartRunning();
        }

        void ConfigureCameraForDevice(AVCaptureDevice device)
        {
            var error = new NSError();
            if (device.IsFocusModeSupported(AVCaptureFocusMode.ContinuousAutoFocus))
            {
                device.LockForConfiguration(out error);
                device.FocusMode = AVCaptureFocusMode.ContinuousAutoFocus;
                device.UnlockForConfiguration();
            }
            else if (device.IsExposureModeSupported(AVCaptureExposureMode.ContinuousAutoExposure))
            {
                device.LockForConfiguration(out error);
                device.ExposureMode = AVCaptureExposureMode.ContinuousAutoExposure;
                device.UnlockForConfiguration();
            }
            else if (device.IsWhiteBalanceModeSupported(AVCaptureWhiteBalanceMode.ContinuousAutoWhiteBalance))
            {
                device.LockForConfiguration(out error);
                device.WhiteBalanceMode = AVCaptureWhiteBalanceMode.ContinuousAutoWhiteBalance;
                device.UnlockForConfiguration();
            }
        }

        partial void SwitchCameraButton_TouchUpInside(UIButton sender)
        {
            var devicePosition = captureDeviceInput.Device.Position;
            if (devicePosition == AVCaptureDevicePosition.Front)
            {
                devicePosition = AVCaptureDevicePosition.Back;
            }
            else
            {
                devicePosition = AVCaptureDevicePosition.Front;
            }

            var device = GetCameraForOrientation(devicePosition);
            ConfigureCameraForDevice(device);

            captureSession.BeginConfiguration();
            captureSession.RemoveInput(captureDeviceInput);
            captureDeviceInput = AVCaptureDeviceInput.FromDevice(device);
            captureSession.AddInput(captureDeviceInput);
            captureSession.CommitConfiguration();
        }

        public AVCaptureDevice GetCameraForOrientation(AVCaptureDevicePosition orientation)
        {
            var devices = AVCaptureDevice.DevicesWithMediaType(AVMediaType.Video);
            foreach (var device in devices)
            {
                if (device.Position == orientation)
                {
                    return device;
                }
            }
            return null;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}