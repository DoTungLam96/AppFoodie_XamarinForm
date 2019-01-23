using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using FoodieApp.Models;
using FoodieApp.Views;
using Xamarin.Forms;

namespace FoodieApp
{
  public class RecipeListViewModel
    {
        public ObservableCollection<ListViewGrouping<Recipe>> AllRecipes
        {
            get { return RecipeData.AllRecipesGrouped; }
        }

        public ICommand AddRecipeCommand { get; } =
            new Command(async (obj) => await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new EditRecipePage())));
    }
}
