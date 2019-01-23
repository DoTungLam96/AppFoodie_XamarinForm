using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
    class StringToValue<T> : IValueConverter
    {
        public T EasyColor { get; set; }
        public T MediumColor { get; set; }
        public T HardColor { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var levelRecipe = value as String;
            if (levelRecipe.GetType() != typeof(string))
            {
                return null;
            }

            if (levelRecipe.Equals(Difficulty.Easy))
            {
                return EasyColor;
            }
            else if (levelRecipe.Equals(Difficulty.Medium))
            {
                return MediumColor;
            }
            else
            {
                return HardColor;
            }       
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
