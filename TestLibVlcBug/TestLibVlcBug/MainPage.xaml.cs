using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestLibVlcBug
{
    public partial class MainPage : ContentPage
    {

        LibVLC _libVLC;
        public MainPage()
        {
            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC(enableDebugLogs: false);
            var _mediaPlayer = new MediaPlayer(_libVLC);
            video.MediaPlayer = _mediaPlayer;
            //The third to fourth seconds will be not smooth
            //第三到四秒会出现不流畅
            _mediaPlayer.Play(new Media(_libVLC, "https://bj.bcebos.com/kpy-organizations/U12760068/videos/2021083110332897820349837654.mp4", FromType.FromLocation));

        }
    }
}
