using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Oode : ContentPage
{
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Oode()
    {
        InitializeComponent();
        random = new Random();
        InitializeRecipes();
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    // Initialize the list of dinner recipes with their details
    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
    {
        new Recipe
        {
            Title = "Hummus ja köögiviljapulgad",
            PreparationTime = "10 minutit",
            Ingredients = new List<string> { "Hummus", "Porgandipulgad", "Kurgiviilud", "Paprikaribad" },
            PreparationSteps = new List<string> { "Aseta hummus kaussi.", "Serveeri koos köögiviljapulkadega." },
            ImageSource = "hummus_koogiviljadega.jpg"
        },
        new Recipe
        {
            Title = "Jogurt ja marjad",
            PreparationTime = "5 minutit",
            Ingredients = new List<string> { "Kreeka jogurt", "Mustikad", "Vaarikad", "Mesi", "Chia seemned" },
            PreparationSteps = new List<string> { "Sega kreeka jogurt marjade ja meega.", "Kaunista chia seemnetega." },
            ImageSource = "jogurt_marjadega.jpg"
        },
        new Recipe
        {
            Title = "Mandlivõi ja õunaviilud",
            PreparationTime = "5 minutit",
            Ingredients = new List<string> { "Õun", "Mandlivõi", "Kaneel" },
            PreparationSteps = new List<string> { "Viiluta õunad.", "Määri õunaviiludele mandlivõid.", "Puista peale kaneeli." },
            ImageSource = "mandlivoi_ounad.jpg"
        },
        new Recipe
        {
            Title = "Kreeka pähklid ja kuivatatud puuviljad",
            PreparationTime = "5 minutit",
            Ingredients = new List<string> { "Kreeka pähklid", "Kuivatatud jõhvikad", "Aprikoosid", "Datlid" },
            PreparationSteps = new List<string> { "Kombineeri kausis erinevad pähklid ja kuivatatud puuviljad." },
            ImageSource = "pahklid_puuviljad.jpg"
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
