using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms.Plugins
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            button1.Clicked += Button1_Clicked;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Plugin.TextToSpeech.CrossTextToSpeech.Current.Speak("Welcome to Xamarin Forms with Xamarin Plugins!");
            
        }
    }
}
