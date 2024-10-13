namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
    public Hommikusook()
    {
        InitializeComponent();
    }

    async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
    {
        // Tagasi NewPage1-le, kus on erinevad toidukordade valikud
        await Navigation.PushAsync(new NewPage1());
    }
}