namespace FoodInspo;

public partial class Lounasook : ContentPage
{
    public Lounasook()
    {
        InitializeComponent();

    }
    async void OnGoBack_Louna(System.Object sender, System.EventArgs e)
    {
        // L�HEB TAGASI SINNA KUS ERINEVAD VALIKUD JUHEI
        await Navigation.PushAsync(new NewPage1());
    }
}