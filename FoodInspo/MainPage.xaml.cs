using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace FoodInspo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AnimateElements();
        }

        private async void AnimateElements()
        {

            await Task.Delay(500);


            await LogoImage.FadeTo(1, 2000);


            await CounterBtn.FadeTo(1, 1000);
        }
        private async void OnCounterClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NewPage1());
        }
    }
}
