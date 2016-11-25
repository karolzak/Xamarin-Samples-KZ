using System;

namespace Native_Plugins
{
    public static class TextToSpeechService
    {
        public static void Speak(string text)
        {

            Plugin.TextToSpeech.CrossTextToSpeech.Current.Speak(text);
        }
    }
}

