using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Linq;
using Microsoft.ProjectOxford.Emotion;
using OxfordEmotion = Microsoft.ProjectOxford.Common.Contract.Emotion;
using UIKit;
using System.Threading.Tasks;
using Xamarin.Cognitive.Face;
using Xamarin.Cognitive.Face.Model;
using System.Collections.Generic;

namespace Mosho
{
    public class ImageAnalyzer
    {
        public ImageAnalyzer()
        {

        }

        public static async Task<double> AnalyzeFace(Emotion emotion, Stream photoStream)
        {
            try
            {
                FaceClient.Shared.SubscriptionKey = "c2a4adb42c0a4ad09be426d67bb72023";
                FaceClient.Shared.Endpoint = Endpoints.WestCentralUS;

                List<Xamarin.Cognitive.Face.Model.Face> result = 
                    await FaceClient.Shared.DetectFacesInPhoto(() => photoStream, FaceAttributeType.Emotion);


                if (result.Count == 0) {
                    return -2;
                }

                var emotions = result[0].Attributes.Emotion;

                switch (emotion)
                {
                    case Emotion.Happy:
                        return emotions.Happiness;
                    case Emotion.Sad:
                        return emotions.Sadness;
                    case Emotion.Angry:
                        return emotions.Anger;
                    case Emotion.Fear:
                        return emotions.Fear;
                    case Emotion.Calm:
                        return emotions.Neutral;
                    case Emotion.TBD:
                        return emotions.Disgust; //TODO
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            return 0;
        }
    }
}