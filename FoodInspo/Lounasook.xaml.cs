using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Lounasook : ContentPage
{
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Lounasook()
    {
        InitializeComponent();
        random = new Random();
        InitializeRecipes();
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    // Initialize the list of lunch recipes with their details
    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                Title = "Kanarind riisiga",
                PreparationTime = "30 minutit",
                Ingredients = new List<string> { "Kanarind", "Riis", "Paprika", "Sojakaste" },
                PreparationSteps = new List<string> { "Keeda riis vastavalt juhendile.", "Grilli kanarind ja lisa paprika.", "Maitsesta sojakastmega." },
                ImageSource = "kanarind_riisiga.jpg"
            },
            new Recipe
            {
                Title = "Ceasari salat",
                PreparationTime = "15 minutit",
                Ingredients = new List<string> { "Rooma salat", "Kana", "Krutoonid", "Parmesan" },
                PreparationSteps = new List<string> { "Tükelda salat ja kana.", "Lisa krutoonid ja parmesan.", "Serveeri kohe." },
                ImageSource = "ceasari_salat.jpg"
            },
            new Recipe
            {
                Title = "Pasta bolognese",
                PreparationTime = "25 minutit",
                Ingredients = new List<string> { "Pasta", "Hakkliha", "Tomatikaste", "Sibul", "Küüslauk" },
                PreparationSteps = new List<string> { "Keeda pasta.", "Küpseta hakkliha sibula ja küüslauguga.", "Lisa tomatikaste ja serveeri pastaga." },
                ImageSource = "pasta_bolognese.jpg"
            },
            new Recipe
            {
                Title = "Köögiviljasupp",
                PreparationTime = "40 minutit",
                Ingredients = new List<string> { "Porgand", "Kartul", "Seller", "Puljong" },
                PreparationSteps = new List<string> { "Tükelda köögiviljad ja keeda puljongis.", "Lisa maitseained ja keeda kuni valmis.", "Serveeri kuumalt." },
                ImageSource = "koogiviljasupp.jpg"
            }
        };
    }

    // Display the current recipe's details
    private void DisplayRecipe(int index)
    {
        var selectedRecipe = recipes[index];

        RecipeTitleLabel.Text = selectedRecipe.Title;
        PreparationTimeLabel.Text = "Valmistusaeg:";
        PreparationTimeValueLabel.Text = selectedRecipe.PreparationTime;
        RecipeImage.Source = selectedRecipe.ImageSource;

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

    // Show a random recipe when "Next Recipe" button is clicked
    private void UusRetseptike(object sender, EventArgs e)
    {
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    // Navigate back when the "Back" button is clicked
    async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}
