using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodieApp.Models
{
   public class ListViewGrouping<T> : List<T>
    {
       
            public string Title
            {
                get;
                set;
            }

            public string ShortName
            {
                get;
                set;
            }

            public ListViewGrouping(string title, string shortName)
            {
                Title = title;
                ShortName = shortName;
            }
        }

        public static class ObservableCollectionExtensions
        {
            public static void AddRangee<T>(this List<T> collection, IEnumerable<T> toAdd)
            {
                foreach (var item in toAdd)
                {
                    collection.Add(item);
                }
            }
        }
}
