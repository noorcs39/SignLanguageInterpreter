using System;

namespace SignLanguageInterpreter
{
    public class SignLanguageInterpreter
    {
        private GestureDetectionSystem _gestureDetectionSystem;
        private SignLanguageToTextConverter _textConverter;
        private TextToSpeechConverter _speechConverter;

        public SignLanguageInterpreter()
        {
            _gestureDetectionSystem = new GestureDetectionSystem();
            _textConverter = new SignLanguageToTextConverter();
            _speechConverter = new TextToSpeechConverter();
        }

        public void StartInterpretation()
        {
            Console.WriteLine("Interpreting sign language...");

            // Simulate detecting a gesture
            string detectedGesture = _gestureDetectionSystem.DetectGesture();

            // Convert gesture to text
            string interpretedText = _textConverter.ConvertGestureToText(detectedGesture);

            // Convert text to speech
            _speechConverter.ConvertTextToSpeech(interpretedText);

            Console.WriteLine("Interpretation complete.");
        }
    }
}
