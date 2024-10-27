using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Joogid : ContentPage
{
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Joogid()
    {
        InitializeComponent();
        random = new Random();
        InitializeRecipes();
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    // Initialize the list of drink recipes with their details
    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                Title = "Värske mahl",
                PreparationTime = "5 minutit",
                Ingredients = new List<string> { "Apelsin", "Sidrun", "Mesi", "Vesi" },
                PreparationSteps = new List<string> { "Pressi apelsini ja sidruni mahl välja.", "Lisa mesi ja sega veega.", "Serveeri koheselt." },
                ImageSource = "varske_mahl.jpg"
            },
            new Recipe
            {
                Title = "Marja smuuti",
                PreparationTime = "10 minutit",
                Ingredients = new List<string> { "Mustikad", "Maasikad", "Jogurt", "Meelepärane piim" },
                PreparationSteps = new List<string> { "Lisa kõik koostisosad blenderisse.", "Blenderda kuni ühtlane.", "Serveeri klaasis." },
                ImageSource = "marja_smuuti.jpg"
            },
            new Recipe
            {
                Title = "Roheline tee sidruniga",
                PreparationTime = "5 minutit",
                Ingredients = new List<string> { "Roheline tee", "Sidrun", "Mesi" },
                PreparationSteps = new List<string> { "Valmista roheline tee.", "Lisa sidruniviil ja mesi maitseks.", "Serveeri kuumalt." },
                ImageSource = "roheline_tee.jpg"
            },
            new Recipe
            {
                Title = "Külm kohv",
                PreparationTime = "15 minutit",
                Ingredients = new List<string> { "Kohv", "Piim", "Jääkuubikud", "Suhkur" },
                PreparationSteps = new List<string> { "Valmista kohv ja lase jahtuda.", "Lisa jääkuubikud ja piim.", "Serveeri külmalt." },
                ImageSource = "kulm_kohv.jpg"
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
