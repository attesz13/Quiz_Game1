using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz_Game
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class closePage : ContentPage
    {
        public closePage(int correct)
        {
            InitializeComponent();
            score.Text=correct.ToString() + "/10";

        }
        private async void HomeButton_OnTapped(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new MainPage());
        }
    }
}