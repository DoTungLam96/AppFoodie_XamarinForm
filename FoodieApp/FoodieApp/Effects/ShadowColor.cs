using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieApp.Effects
{
   public class ShadowColor : RoutingEffect
    {
        public ShadowColor() : base("com.codemilltech.ShadowEffect")
        {

        }

        public Color ShadowColorEffect { get; set; } = Color.Azure;
    }
}
