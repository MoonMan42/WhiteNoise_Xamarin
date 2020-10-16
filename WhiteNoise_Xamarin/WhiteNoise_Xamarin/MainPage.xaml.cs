
using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace WhiteNoise_Xamarin
{
    public partial class MainPage : ContentPage
    {
        // added Xam.Plugin.SimpleAudioPlayer in nuget
        //https://devblogs.microsoft.com/xamarin/adding-sound-xamarin-forms-app/

        ISimpleAudioPlayer player;

        public MainPage()
        {
            InitializeComponent();

            player = CrossSimpleAudioPlayer.Current;
        }

        private void StartPlay_Click(object sender, EventArgs e)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("WhiteNoise_Xamarin." + "WhiteOceanNoise.mp3");

            player.Load(audioStream);

            player.Play();
        }

        private void StopPlay_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
