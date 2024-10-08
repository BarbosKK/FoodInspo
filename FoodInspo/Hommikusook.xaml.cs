namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
	// Loome loetelu retseptide pealkirjadest, koostisosadest, piltidest ja juhistest
	private List<Tuple<string, List<string>, string, string>> recipes = new List<Tuple<string, List<string>, string, string>>()
	{
		new Tuple<string, List<string>, string, string>(
			"Kaerahelbepuder marjadega",
			new List<string> { "Vaja läheb", "Kaerahelbed", "Marjad", "Piim" },
			"kaerahelbepuder.jpg", // Pildi nimi
            "Keeda kaerahelbed piimaga, lisa peale värsked marjad."
		),
		new Tuple<string, List<string>, string, string>(
			"Omlett juustu ja singiga",
			new List<string> { "Vaja läheb", "Munad", "Juust", "Sink" },
			"omlett.jpg",
			"Klopi munad, lisa juust ja sink. Prae pannil kuldpruuniks."
		),
		new Tuple<string, List<string>, string, string>(
			"Tortilla munade ja avokaadoga",
			new List<string> { "Vaja läheb", "Tortilla", "Munad", "Avokaado", "Juust" },
			"tortilla.jpg",
			"Prae munad, tükelda avokaado. Pane kõik koostisosad tortilla sisse."
		),
        // Lisa ülejäänud retseptid samamoodi...
    };

	// Praegune retsepti indeks
	private int currentRecipeIndex = 0;

	public Hommikusook()
	{
		InitializeComponent();
		ShowRecipe(); // Kuvame esimese retsepti
	}

	// Funktsioon retsepti kuvamiseks
	private void ShowRecipe()
	{
		// Seadistame sildi (Label) tekstiks praeguse retsepti pealkirja
		RecipeLabel.Text = recipes[currentRecipeIndex].Item1;

		// Kuvame pildi
		RecipeImage.Source = recipes[currentRecipeIndex].Item3;

		// Puhastame eelnevad koostisosad
		IngredientsLayout.Children.Clear();

		// Lisame koostisosad üksteise alla
		foreach (var ingredient in recipes[currentRecipeIndex].Item2)
		{
			IngredientsLayout.Children.Add(new Label { Text = ingredient, FontSize = 14, HorizontalOptions = LayoutOptions.Center });
		}

		// Kuvame valmistamisjuhised
		RecipeInstructions.Text = recipes[currentRecipeIndex].Item4;
	}

	// Kui vajutatakse "Next Recipe" nuppu
	void OnNextRecipeClicked(object sender, EventArgs e)
	{
		// Liigume järgmise retsepti juurde, võttes arvesse loetelu pikkust
		currentRecipeIndex = (currentRecipeIndex + 1) % recipes.Count;
		ShowRecipe(); // Kuvame uue retsepti
	}

	// Kui vajutatakse tagasi nuppu
	async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
	{
		// LÄHEB TAGASI SINNA KUS ERINEVAD VALIKUD JUHEI
		await Navigation.PushAsync(new NewPage1());
	}
}
