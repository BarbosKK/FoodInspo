using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInspo.Models  // Või FoodInspo.Recipes, kui kausta nimi on Recipes
{
    public class Recipe
    {
        public string Title { get; set; }
        public string PreparationTime { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> PreparationSteps { get; set; }
    }
}

