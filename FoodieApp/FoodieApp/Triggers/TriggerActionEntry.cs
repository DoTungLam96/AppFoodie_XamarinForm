using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp
{
   public class TriggerActionEntry : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = string.IsNullOrEmpty(sender.Text) ? Color.FromHex("#FFCDD2") : Color.Default;
        }
    }
}
