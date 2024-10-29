using FoodInspo.Models;


namespace FoodInspo
{
    public partial class HommikusookDetailPage : ContentPage
    {
        public HommikusookDetailPage(Recipe recipe)
        {
            InitializeComponent();
            DisplayRecipe(recipe);
        }

        private void DisplayRecipe(Recipe recipe)
        {
            RecipeTitleLabel.Text = recipe.Title;
            PreparationTimeValueLabel.Text = recipe.PreparationTime;

            IngredientsList.Children.Clear();
            foreach (var ingredient in recipe.Ingredients)
            {
                IngredientsList.Children.Add(new Label
                {
                    Text = ingredient,
                    TextColor = Color.FromHex("#333"),
                    FontSize = 18
                });
            }

            PreparationSteps.Children.Clear();
            foreach (var step in recipe.PreparationSteps)
            {
                PreparationSteps.Children.Add(new Label
                {
                    Text = step,
                    TextColor = Color.FromHex("#333"),
                    FontSize = 18
                });
            }
        }
    }
}

