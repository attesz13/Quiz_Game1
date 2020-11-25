using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz_Game
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundImage = "HPBG.png";
        }

        private async void PlayButton_OnTapped(object sender, EventArgs e)
        {
            await Task.WhenAll(ImgTitle.TranslateTo(0, -1000, 1000),
                ImgPlayButton.FadeTo(0,1000)
                );
            await Navigation.PushModalAsync(new GamePlay());
        }
        
    }
}
