namespace FoodInspo;

public partial class Ohtusook : ContentPage
{
	public Ohtusook()
	{
		InitializeComponent();
	}

	async void OnGoBack_Ohtu(System.Object sender, System.EventArgs e)
	{
		// L�HEB TAGASI SINNA KUS ERINEVAD VALIKUD JUHEI
		await Navigation.PushAsync(new NewPage1());
	}
}
