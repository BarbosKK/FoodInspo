using Microsoft.Maui.Controls;

namespace FoodInspo
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        async void OnCounterClicked_2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;

            if (button != null && button.Source is FileImageSource fileImageSource)
            {
                // Check the file name of the image source to determine which page to navigate to
                switch (fileImageSource.File)
                {
                    case "hommikusook.png":
                        await Navigation.PushAsync(new Hommikusook());
                        break;
                    case "lounasook.png":
                        await Navigation.PushAsync(new Lounasook());
                        break;
                    case "ohtusook.png":
                        await Navigation.PushAsync(new Ohtusook());
                        break;
                    case "oode.png":
                        await Navigation.PushAsync(new Oode());
                        break;
                    case "joogid.png":
                        await Navigation.PushAsync(new Joogid());
                        break;
                    case "magustoit.png":
                        await Navigation.PushAsync(new Magustoit());
                        break;
                    default:
                        await DisplayAlert("Nupp", "Vale", "OK");
                        break;
                }
            }
        }
    }
}
