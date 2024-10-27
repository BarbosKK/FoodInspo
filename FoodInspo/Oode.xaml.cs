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

    // Initialize the list of snack recipes with their details
    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                Title = "Jogurt marjadega",
                PreparationTime = "5 minutit",
                Ingredients = new List<string> { "Jogurt", "Marjad (mustikad, vaarikad)", "Mesi" },
                PreparationSteps = new List<string> { "Lisa jogurt kaussi.", "Sega juurde marjad ja mesi.", "Serveeri koheselt." },
                ImageSource = "jogurt_marjadega.jpg"
            },
            new Recipe
            {
                Title = "Smoothie",
                PreparationTime = "10 minutit",
                Ingredients = new List<string> { "Banaan", "Spinat", "Kookospiim", "Marjad" },
                PreparationSteps = new List<string> { "Lisa kõik koostisosad blenderisse.", "Blenderda kuni segu on ühtlane.", "Serveeri klaasis." },
                ImageSource = "smoothie.jpg"
            },
            new Recipe
            {
                Title = "Tervislik müsli",
                PreparationTime = "15 minutit",
                Ingredients = new List<string> { "Kaerahelbed", "Pähklid", "Kookoshelbed", "Meelepärane piim" },
                PreparationSteps = new List<string> { "Sega kokku kaerahelbed, pähklid ja kookoshelbed.", "Serveeri koos piimaga." },
                ImageSource = "tervislik_musli.jpg"
            },
            new Recipe
            {
                Title = "Hummus ja köögiviljad",
                PreparationTime = "10 minutit",
                Ingredients = new List<string> { "Hummus", "Paprika", "Porgand", "Kurkum" },
                PreparationSteps = new List<string> { "Lõika köögiviljad ribadeks.", "Serveeri hummusega dipikastmeks." },
                ImageSource = "hummus_koogiviljadega.jpg"
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
