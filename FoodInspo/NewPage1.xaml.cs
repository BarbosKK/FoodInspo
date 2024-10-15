namespace FoodInspo
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;

            if (button != null && button.Source is FileImageSource fileImageSource)
            {
                switch (fileImageSource.File)
                {
                    case "hommik.png":
                        await Navigation.PushAsync(new Hommikusook());
                        break;
                    default:
                        await DisplayAlert("Nupp", "Suphoe", "OK");
                        break;
                }
            }
        }
    }
}
