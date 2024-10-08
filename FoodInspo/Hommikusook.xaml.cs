namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
	public Hommikusook()
	{
		InitializeComponent();
	}

	async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
    {
        // LÄHEB TAGASI SINNA KUS ERINEVAD VALIKUD JUHEI
        await Navigation.PushAsync(new NewPage1());
    }
}