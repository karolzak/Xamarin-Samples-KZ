using System;

namespace XamNative.Plugins
{
    public static class TextToSpeechService
    {
        public static void Speak(string text)
        {

            Plugin.TextToSpeech.CrossTextToSpeech.Current.Speak(text);
        }
    }
}

