using System;

namespace SignLanguageInterpreter
{
    public class SignLanguageToTextConverter
    {
        public string ConvertGestureToText(string gesture)
        {
            // Simulate conversion of detected gesture to text
            Console.WriteLine($"Converting gesture '{gesture}' to text...");

            // Example conversion logic
            switch (gesture)
            {
                case "wave":
                    return "Hello";
                case "thumbs_up":
                    return "Good job";
                case "clap":
                    return "Well done";
                default:
                    return "Unknown gesture";
            }
        }
    }
}
