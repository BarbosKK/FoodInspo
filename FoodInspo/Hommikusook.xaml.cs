using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
<<<<<<< HEAD
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
=======
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Hommikusook()
    {
        InitializeComponent();
        random = new Random();
        InitializeRecipes();
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                Title = "Avokaado sai",
                PreparationTime = "20 minutit",
                Ingredients = new List<string>
                {
                    "2 muna",
                    "1 viil täisteraleiba",
                    "1 avokaado",
                    "Näpuotsatäis soola ja pipart"
                },
                PreparationSteps = new List<string>
                {
                    "1. Prae munad vastavalt oma eelistustele.",
                    "2. Röstige leib ja määrige avokaadopüree peale.",
                    "3. Maitsesta soola ja pipraga."
                }
            },
            new Recipe
            {
                Title = "Kreeka jogurt marjadega",
                PreparationTime = "10 minutit",
                Ingredients = new List<string>
                {
                    "1 tass Kreeka jogurtit",
                    "1/2 tass segatud marju (maasikad, mustikad, vaarikad)",
                    "1 spl mett",
                    "1/4 tl vanilliekstrakti"
                },
                PreparationSteps = new List<string>
                {
                    "1. Sega jogurt, mesi ja vanilliekstrakt kokku.",
                    "2. Lisa marjad ja sega õrnalt.",
                    "3. Serveeri kohe."
                }
            },
            new Recipe
            {
                Title = "Muna ja peekon",
                PreparationTime = "15 minutit",
                Ingredients = new List<string>
                {
                    "2 muna",
                    "2 viilu peekonit",
                    "1 viil leiba",
                    "Näpuotsatäis soola"
                },
                PreparationSteps = new List<string>
                {
                    "1. Prae peekon pannil kuni see on krõbe.",
                    "2. Eemalda peekon ja prae munad samas pannil.",
                    "3. Serveeri muna peekoniga koos röstsaiaga."
                }
            },
            new Recipe
            {
                Title = "Puuviljasalat",
                PreparationTime = "15 minutit",
                Ingredients = new List<string>
                {
                    "1 banaan",
                    "1 õun",
                    "1/2 tass viinamarju",
                    "1/2 tass apelsinimahla"
                },
                PreparationSteps = new List<string>
                {
                    "1. Lõika banaan ja õun kuubikuteks.",
                    "2. Lisa viinamarjad ja sega kokku.",
                    "3. Nirista peale apelsinimahl ja serveeri."
                }
            },
        };
    }

    private void DisplayRecipe(int index)
    {
        var selectedRecipe = recipes[index];

        RecipeTitleLabel.Text = selectedRecipe.Title;
        PreparationTimeLabel.Text = "Valmistusaeg:";
        PreparationTimeValueLabel.Text = selectedRecipe.PreparationTime;

        IngredientsList.Children.Clear();
        foreach (var ingredient in selectedRecipe.Ingredients)
        {
            IngredientsList.Children.Add(new Label
            {
                Text = ingredient,
                TextColor = Color.FromHex("#333"),
                FontSize = 18
            });
        }

        PreparationSteps.Children.Clear();
        foreach (var step in selectedRecipe.PreparationSteps)
        {
            PreparationSteps.Children.Add(new Label
            {
                Text = step,
                TextColor = Color.FromHex("#333"),
                FontSize = 18
            });
        }
    }

    private void UusRetseptike(object sender, EventArgs e)
    {
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}

public class Recipe
{
    public string Title { get; set; }
    public string PreparationTime { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> PreparationSteps { get; set; }
>>>>>>> origin/Lauren
}
