using System;
using System.Collections.Generic;
using System.Text;

namespace FoodieApp
{
   public class RecipeGroups : List<Recipe>
    {
        public  string Title { get; set; }
        public  string ShortName { get; set; }

        public RecipeGroups(String title, String shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
