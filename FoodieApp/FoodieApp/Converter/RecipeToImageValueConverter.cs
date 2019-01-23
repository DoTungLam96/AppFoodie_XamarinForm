using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
   public class RecipeToImageValueConverter : IValueConverter
    {
        public string AssemblyImage { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = value as string;
            if (string.IsNullOrEmpty(source))
            {
                return null;
            }

            var imagePath = $"{AssemblyImage}.{source}";
            return ImageSource.FromResource(imagePath);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
