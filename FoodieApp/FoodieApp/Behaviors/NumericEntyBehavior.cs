using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
   public class NumericEntyBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += TextChange_Handler;
            base.OnAttachedTo(bindable);
           
        }

        void TextChange_Handler(object e , TextChangedEventArgs args)
        {
            if (string.IsNullOrEmpty(args.NewTextValue))
            {
                 return;                
            }

            double _;
            if (!double.TryParse(args.NewTextValue, out _))
            {
                ((Entry) e).Text = args.OldTextValue;
            }
        }

        //Huy dang ky lang nghe su kien textchange
        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= TextChange_Handler;
            base.OnDetachingFrom(bindable);   
        }
    }
}
