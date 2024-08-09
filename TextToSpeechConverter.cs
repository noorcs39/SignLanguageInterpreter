using System;
using System.Speech.Synthesis; // You'll need to add a reference to System.Speech

namespace SignLanguageInterpreter
{
    public class TextToSpeechConverter
    {
        public void ConvertTextToSpeech(string text)
        {
            // Convert text to speech
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                Console.WriteLine($"Converting text '{text}' to speech...");
                synth.Speak(text);
            }
        }
    }
}
