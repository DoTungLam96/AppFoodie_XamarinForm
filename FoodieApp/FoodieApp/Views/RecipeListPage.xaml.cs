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
	public partial class RecipeListPage : ContentPage
	{
		public RecipeListPage ()
		{
			InitializeComponent ();
            BindingContext = new RecipeListViewModel();
		}

	    private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        
	            var recipe = e.SelectedItem as Recipe;

	            if (recipe == null)
	                return;

	            var detailPage = new RecipeDetailPage(recipe);
	            await Navigation.PushAsync(detailPage);

	            recipeList.SelectedItem = null;
	        
        }
	}
}