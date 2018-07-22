using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechRecognition;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwp
{
   

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CoreDispatcher dispatcher;
        private StringBuilder dictatedTextBuilder;
        private SpeechRecognizer speechRecognizer;

        public MainPage()
        {
            this.InitializeComponent();  
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
  //          this.speechRecognizer = new SpeechRecognizer();
  //          this.speechRecognizer = new SpeechRecognizer();
  //          speechRecognizer.Constraints.Add(new SpeechRecognitionListConstraint(new List<String>() { "Hola" }, "Hola"));
  //          speechRecognizer.ContinuousRecognitionSession.ResultGenerated +=
  //  ContinuousRecognitionSession_ResultGenerated;
  //          speechRecognizer.ContinuousRecognitionSession.Completed +=
  //ContinuousRecognitionSession_Completed;

  //          speechRecognizer.HypothesisGenerated += SpeechRecognizer_HypothesisGenerated;

        }


        async void clickStart(object sender, RoutedEventArgs e)
        {


            // Create an instance of SpeechRecognizer.
            var speechRecognizer = new Windows.Media.SpeechRecognition.SpeechRecognizer();

            // Compile the dictation grammar by default.
            await speechRecognizer.CompileConstraintsAsync();

            // Start recognition.
            Windows.Media.SpeechRecognition.SpeechRecognitionResult speechRecognitionResult = await speechRecognizer.RecognizeWithUIAsync();

            // Do something with the recognition result.
            var messageDialog = new Windows.UI.Popups.MessageDialog(speechRecognitionResult.Text, "Text spoken");
            await messageDialog.ShowAsync();

            //Task.Factory.StartNew(async () =>
            //{
            //    try
            //    {
            //          Speech.Initialize();
            //await Speech.StartRecognition();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }

            //});

        }
      
  //      private async void ContinuousRecognitionSession_ResultGenerated(
  //SpeechContinuousRecognitionSession sender,
  //SpeechContinuousRecognitionResultGeneratedEventArgs args)
  //      {

  //          if (args.Result.Confidence == SpeechRecognitionConfidence.Medium ||
  //            args.Result.Confidence == SpeechRecognitionConfidence.High)
  //          {
  //              dictatedTextBuilder.Append(args.Result.Text + " ");

  //              await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
  //              {
  //                  txtResults.Text = dictatedTextBuilder.ToString();
  //              });
  //          }
  //          else
  //          {
  //              await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
  //              {
  //                  txtResults.Text = dictatedTextBuilder.ToString();
  //              });
  //          }
  //      }


  //      private async void ContinuousRecognitionSession_Completed(
  //SpeechContinuousRecognitionSession sender,
  //SpeechContinuousRecognitionCompletedEventArgs args)
  //      {
  //          if (args.Status != SpeechRecognitionResultStatus.Success)
  //          {
  //              if (args.Status == SpeechRecognitionResultStatus.TimeoutExceeded)
  //              {
  //                  await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
  //                  {
  //                      //rootPage.NotifyUser(
  //                      //  "Automatic Time Out of Dictation",
  //                      //  NotifyType.StatusMessage);

  //                      //Bu.Text = " Continuous Recognition";
  //                      txtResults.Text = dictatedTextBuilder.ToString();
  //                  });
  //              }
  //              else
  //              {
  //                  await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
  //                  {
  //                      //rootPage.NotifyUser(
  //                      //  "Continuous Recognition Completed: " + args.Status.ToString(),
  //                      //  NotifyType.StatusMessage);

  //                      txtResults.Text = " Continuous Recognition";
  //                  });
  //              }
  //          }
  //      }


  //      private async void SpeechRecognizer_HypothesisGenerated(
  //SpeechRecognizer sender,
  //SpeechRecognitionHypothesisGeneratedEventArgs args)
  //      {

  //          string hypothesis = args.Hypothesis.Text;
  //          string textboxContent = dictatedTextBuilder.ToString() + " " + hypothesis + " ...";

  //          await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
  //          {
  //              txtResults.Text = textboxContent;
  //          });
  //      }

       
    }


}
