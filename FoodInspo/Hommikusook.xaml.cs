using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Hommikusook : ContentPage
{
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
}
