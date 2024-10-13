namespace FoodInspo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnCounterClicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new NewPage1());
    }
}