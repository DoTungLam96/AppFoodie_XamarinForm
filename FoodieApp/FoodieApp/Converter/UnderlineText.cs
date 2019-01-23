using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
    public class UnderlineText : Label
    {    
            public static readonly BindableProperty IsUnderlinedProperty = BindableProperty.Create("IsUnderlined", typeof(bool), typeof(UnderlineText), false);

            public bool IsUnderlined
            {
                get { return (bool)GetValue(IsUnderlinedProperty); }
                set { SetValue(IsUnderlinedProperty, value); }
            }    
    }
}
