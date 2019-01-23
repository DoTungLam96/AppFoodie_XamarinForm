using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodieApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditRecipePage : ContentPage
	{
	    Recipe _recipe;
	    Recipe _originalRecipe;
        int id;
        List<Recipe> recipesList = new List<Recipe>();
	    bool isNew = false;

	    public EditRecipePage()
	    {
	        InitializeComponent();

	        _recipe = new Recipe();
	        BindingContext = _recipe;
            recipesList.Add(_recipe);
	        isNew = true;
	    }

	    public EditRecipePage(Recipe recipe)
	    {
	        InitializeComponent();

	        _recipe = recipe;
	        _originalRecipe = recipe.Copy();
            id = _recipe.Id;
	        mealPicker.SelectedIndex = mealPicker.Items.IndexOf(_recipe.MealType);
	        difficultyPicker.SelectedIndex = difficultyPicker.Items.IndexOf(_recipe.Difficulty);
            recipesList.Add(_recipe);
	        BindingContext = _recipe;
	    }

	    async void HandleSave_Clicked(object sender, System.EventArgs e)
	    {
            var itemIndex = recipesList.IndexOf(_recipe);
            var item = recipesList.ElementAt(itemIndex);
            _recipe.Difficulty = difficultyPicker.Items[difficultyPicker.SelectedIndex];
            _recipe.MealType = mealPicker.Items[mealPicker.SelectedIndex];

            if (isNew)
	        {
	            var grouping = RecipeData.AllRecipesGrouped.First(arg => arg.Title == _recipe.Difficulty);
	            grouping.Add(_recipe);
            }
            else
            {

                recipesList.RemoveAt(itemIndex);
                recipesList.Insert(itemIndex, item);
            }
            await Navigation.PopModalAsync();
	    }

	    async void HandleCancel_Clicked(object sender, System.EventArgs e)
	    {
	        if (!isNew)
	        {
	            _recipe.CookTime = _originalRecipe.CookTime;
	            _recipe.Difficulty = _originalRecipe.Difficulty;
	            _recipe.Directions = _originalRecipe.Directions;
	            _recipe.Ingredients = _originalRecipe.Ingredients;
	            _recipe.IsRecommended = _originalRecipe.IsRecommended;
	            _recipe.MealType = _originalRecipe.MealType;
	            _recipe.NumberOfServings = _originalRecipe.NumberOfServings;
	            _recipe.PreparationTime = _originalRecipe.PreparationTime;
	            _recipe.RecipeName = _originalRecipe.RecipeName;
	            _recipe.WillMakeAgain = _originalRecipe.WillMakeAgain;
	        }

	        await Navigation.PopModalAsync();
	    }

    }
}