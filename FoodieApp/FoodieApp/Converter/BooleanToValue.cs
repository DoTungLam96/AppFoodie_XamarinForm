﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
    public class BoolToValue<T> : IValueConverter
    {
        //public Color TrueColor { get; set; }
        //public Color FalseColor { get; set}

        public T TrueValue { get; set; }
        public T FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(bool))
                return FalseValue;

            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            if (value.GetType() != typeof(T))
                return false;

            return ((T)value).Equals(TrueValue);
        }
    }
}
