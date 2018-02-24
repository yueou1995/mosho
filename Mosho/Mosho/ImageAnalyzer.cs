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

        public static async Task<double> AnalyzeFace(Emotion emotion)
        {
            try
            {
                FaceClient.Shared.SubscriptionKey = "c2a4adb42c0a4ad09be426d67bb72023";
                FaceClient.Shared.Endpoint = Endpoints.WestCentralUS;

                using (var photoStream = UIImage.FromBundle("AngryBoy.jpg").AsPNG().AsStream())
                {
                    List<Xamarin.Cognitive.Face.Model.Face> result = await FaceClient.Shared.DetectFacesInPhoto(() => photoStream, FaceAttributeType.Emotion);


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

            }
            catch (Exception e)
            {
                return -1;
            }
            return 0;
        }

        public static async Task<double> AnalyzeEmotion(Emotion emotion)
        {
            try
            {
                var emotionClient = new EmotionServiceClient("a17ec616d6f1493fbb57a3a13893f86d");
                using (var photoStream = UIImage.FromBundle("SadBoy.jpg").AsPNG().AsStream())
                {
                    OxfordEmotion[] emotionResult = await emotionClient.RecognizeAsync(photoStream);
                    if (emotionResult.Any())
                    {
                        var scores = emotionResult.FirstOrDefault().Scores;
                        switch (emotion)
                        {
                            case Emotion.Happy:
                                return scores.Happiness;
                            case Emotion.Sad:
                                return scores.Sadness;
                            case Emotion.Angry:
                                return scores.Anger;
                            case Emotion.Fear:
                                return scores.Fear;
                            case Emotion.Calm:
                                return scores.Neutral;
                            case Emotion.TBD:
                                return scores.Disgust; //TODO
                        }
                    }
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