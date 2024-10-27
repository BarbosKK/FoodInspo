using Microsoft.Maui.Controls;

namespace FoodInspo;

public partial class Ohtusook : ContentPage
{
    private List<Recipe> recipes;
    private Random random;
    private int currentRecipeIndex;

    public Ohtusook()
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
                Title = "Grillitud lõhe köögiviljadega",
                PreparationTime = "30 minutit",
                Ingredients = new List<string> { "Lõhefilee", "Spargel", "Paprika", "Oliiviõli", "Sool ja pipar" },
                PreparationSteps = new List<string> { "Maitsesta lõhe soola ja pipraga.", "Grilli lõhe ja köögiviljad.", "Serveeri kuumalt." },
                ImageSource = "grillitud_lohe.jpg"
            },
            new Recipe
            {
                Title = "Veiselihapada",
                PreparationTime = "1 tund",
                Ingredients = new List<string> { "Veiseliha", "Kartul", "Porgand", "Sibul", "Puljong" },
                PreparationSteps = new List<string> { "Pruunista veiseliha.", "Lisa tükeldatud köögiviljad ja puljong.", "Küpseta ahjus 1 tund." },
                ImageSource = "veisepada.jpg"
            },
            new Recipe
            {
                Title = "Ahjukana ja kartul",
                PreparationTime = "45 minutit",
                Ingredients = new List<string> { "Kanakoivad", "Kartul", "Oliiviõli", "Küüslauk", "Rosmariin" },
                PreparationSteps = new List<string> { "Maitsesta kana ja kartulid.", "Küpseta ahjus 45 minutit.", "Serveeri värske rosmariiniga." },
                ImageSource = "ahjukana.jpg"
            },
            new Recipe
            {
                Title = "Risotto seentega",
                PreparationTime = "35 minutit",
                Ingredients = new List<string> { "Risottoriis", "Seen", "Puljong", "Parmesan", "Või" },
                PreparationSteps = new List<string> { "Prae seened võiga.", "Lisa riis ja puljong vähehaaval.", "Lisa parmesan ja sega kuni kreemjas." },
                ImageSource = "seenerisotto.jpg"
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
