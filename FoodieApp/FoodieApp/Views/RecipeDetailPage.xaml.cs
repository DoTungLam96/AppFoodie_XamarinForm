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
	public partial class RecipeDetailPage : ContentPage
	{
	    private Recipe _selectedRecipe;
        List<Recipe> recipesList = new List<Recipe>();
        public RecipeDetailPage (Recipe recipe)
		{
			InitializeComponent ();
		    _selectedRecipe = recipe;
            recipesList.Add(_selectedRecipe);
            BindingContext = recipe;
		}
	    async void EditRecipe_Clicked(object sender, System.EventArgs e)
	    {
	        var editPage = new NavigationPage(new EditRecipePage(_selectedRecipe));

	        await Navigation.PushModalAsync(editPage);
	    }

        private void MakeAgain_Clicked(object sender, EventArgs e)
        {
            var itemIndex = recipesList.IndexOf(_selectedRecipe);
            var item = recipesList.ElementAt(itemIndex);
            recipesList.RemoveAt(itemIndex);

            item.WillMakeAgain = false;
            recipesList.Insert(itemIndex, item);
            Navigation.PushAsync(new RecipeListPage());
        }
    }
}