using System;
using System.Collections.Generic;
using System.Text;
using FoodieApp.CellPage;
using Xamarin.Forms;

namespace FoodieApp
{
    public class RecipeDataTemplate : DataTemplateSelector
    {
        DataTemplate recipeTemplate;
        DataTemplate recommendedTemplate;

        public RecipeDataTemplate()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedTemplate = new DataTemplate(typeof(RecommendCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;
            if (recipe == null)
            {
                return null;
            }

            return recipe.IsRecommended ? recommendedTemplate : recipeTemplate;
        }
    }
}