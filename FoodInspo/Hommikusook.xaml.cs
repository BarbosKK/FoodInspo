namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
	// Loome loetelu retseptide pealkirjadest, koostisosadest, piltidest ja juhistest
	private List<Tuple<string, List<string>, string, string>> recipes = new List<Tuple<string, List<string>, string, string>>()
	{
		new Tuple<string, List<string>, string, string>(
			"Kaerahelbepuder marjadega",
			new List<string> { "Vaja l�heb", "Kaerahelbed", "Marjad", "Piim" },
			"kaerahelbepuder.jpg", // Pildi nimi
            "Keeda kaerahelbed piimaga, lisa peale v�rsked marjad."
		),
		new Tuple<string, List<string>, string, string>(
			"Omlett juustu ja singiga",
			new List<string> { "Vaja l�heb", "Munad", "Juust", "Sink" },
			"omlett.jpg",
			"Klopi munad, lisa juust ja sink. Prae pannil kuldpruuniks."
		),
		new Tuple<string, List<string>, string, string>(
			"Tortilla munade ja avokaadoga",
			new List<string> { "Vaja l�heb", "Tortilla", "Munad", "Avokaado", "Juust" },
			"tortilla.jpg",
			"Prae munad, t�kelda avokaado. Pane k�ik koostisosad tortilla sisse."
		),
        // Lisa �lej��nud retseptid samamoodi...
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

		// Lisame koostisosad �ksteise alla
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
		// Liigume j�rgmise retsepti juurde, v�ttes arvesse loetelu pikkust
		currentRecipeIndex = (currentRecipeIndex + 1) % recipes.Count;
		ShowRecipe(); // Kuvame uue retsepti
	}

	// Kui vajutatakse tagasi nuppu
	async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
	{
		// L�HEB TAGASI SINNA KUS ERINEVAD VALIKUD JUHEI
		await Navigation.PushAsync(new NewPage1());
	}
}
