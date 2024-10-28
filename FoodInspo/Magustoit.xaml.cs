using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Magustoit : ContentPage
{
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Magustoit()
    {
        InitializeComponent();
        random = new Random();
        InitializeRecipes();
        currentRecipeIndex = random.Next(recipes.Count);
        DisplayRecipe(currentRecipeIndex);
    }

    // Initialize the list of dessert recipes with their details
    private void InitializeRecipes()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                Title = "Šokolaadi mousse",
                PreparationTime = "20 minutit",
                Ingredients = new List<string> { "Šokolaad", "Vahukoor", "Suhkur", "Munad" },
                PreparationSteps = new List<string> { "Sulata šokolaad ja sega munadega.", "Vahusta koor ja sega šokolaadi hulka.", "Jahuta enne serveerimist." },
                ImageSource = "sokolaadi_mousse.jpg"
            },
            new Recipe
            {
                Title = "Marjapavlova",
                PreparationTime = "1 tund",
                Ingredients = new List<string> { "Munavalged", "Suhkur", "Vanilje", "Marjad" },
                PreparationSteps = new List<string> { "Vahusta munavalged ja lisa suhkur.", "Küpseta ahjus kuni krõbe.", "Kaunista marjade ja vaniljekreemiga." },
                ImageSource = "marjapavlova.jpg"
            },
            new Recipe
            {
                Title = "Pannkoogid moosiga",
                PreparationTime = "30 minutit",
                Ingredients = new List<string> { "Jahu", "Piim", "Muna", "Moos" },
                PreparationSteps = new List<string> { "Sega jahu, piim ja muna.", "Prae tainas pannil kuldseks.", "Serveeri koos moosiga." },
                ImageSource = "pannkoogid.jpg"
            },
            new Recipe
            {
                Title = "Õunakook",
                PreparationTime = "45 minutit",
                Ingredients = new List<string> { "Õunad", "Jahu", "Või", "Suhkur", "Kaneel" },
                PreparationSteps = new List<string> { "Valmista tainas ja kata õuntega.", "Maitsesta kaneeliga ja küpseta ahjus.", "Serveeri soojalt või külmalt." },
                ImageSource = "ounakook.jpg"
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
