using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;

namespace uwp
{
    class Speech
    {
        private static SpeechRecognizer speechRecognizer;
        private static StringBuilder dictatedTextBuilder;

        public async static void Initialize()
        {
            speechRecognizer = new SpeechRecognizer();

            SpeechRecognitionCompilationResult compilationResult = await speechRecognizer.CompileConstraintsAsync();
            dictatedTextBuilder = new StringBuilder();
            speechRecognizer.ContinuousRecognitionSession.Completed += ContinuousRecognitionSession_Completed;
            speechRecognizer.ContinuousRecognitionSession.ResultGenerated += ContinuousRecognitionSession_ResultGenerated;
            speechRecognizer.HypothesisGenerated += SpeechRecognizer_HypothesisGenerated;
            
        }

        private static void ContinuousRecognitionSession_ResultGenerated(SpeechContinuousRecognitionSession sender,SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {

            if (args.Result.Confidence == SpeechRecognitionConfidence.Medium ||
              args.Result.Confidence == SpeechRecognitionConfidence.High)
            {
                dictatedTextBuilder.Append(args.Result.Text + "-aqui-");
            }
            else
            {

            }
        }

        public static async Task<bool> StartRecognition()
        {
            try
            {
                await speechRecognizer.ContinuousRecognitionSession.StartAsync();
            }
            catch (Exception eException)
            {
                await speechRecognizer.ContinuousRecognitionSession.StopAsync();
                return false;
            }

            return true;
        }


        private static void ContinuousRecognitionSession_Completed(SpeechContinuousRecognitionSession sender,SpeechContinuousRecognitionCompletedEventArgs args)
        {
            if (args.Status != SpeechRecognitionResultStatus.Success)
            {
                if (args.Status == SpeechRecognitionResultStatus.TimeoutExceeded)
                {
                   
                }
                else
                {
                  
                }
            }
        }


        private static void SpeechRecognizer_HypothesisGenerated(
  SpeechRecognizer sender,
  SpeechRecognitionHypothesisGeneratedEventArgs args)
        {

            

          
        }


    }
}
