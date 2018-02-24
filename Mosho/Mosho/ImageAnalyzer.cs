using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Linq;
using Microsoft.ProjectOxford.Emotion;
using OxfordEmotion = Microsoft.ProjectOxford.Common.Contract.Emotion;
using UIKit;
using System.Threading.Tasks;

namespace Mosho
{
    public class ImageAnalyzer
    {
        public ImageAnalyzer()
        {
        }

        public static async Task<double> Analyze(Emotion emotion)
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
            } catch (Exception e) {
                bool b = true;
            }
            return 0;

        }
    }
}