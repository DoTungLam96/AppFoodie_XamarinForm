using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Foodie.Droid;
using FoodieApp.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using VisualElement = Xamarin.Forms.PlatformConfiguration.iOSSpecific.VisualElement;

[assembly: ResolutionGroupName("com.codemilltech")]
[assembly: ExportEffect(typeof(TextviewShadowEffect), "ShadowEffect")]
namespace Foodie.Droid
{
    public class TextviewShadowEffect : PlatformEffect
    {
        Android.Graphics.Color oldColor;
        float oldRadius;
        float oldDx;
        float oldDy;

        protected override void OnAttached()
        {
            var tv = Control as TextView;

            oldColor = tv.ShadowColor;
            oldRadius = tv.ShadowRadius;
            oldDx = tv.ShadowDx;
            oldDy = tv.ShadowDy;
            
            var routingEffect = (ShadowColor) Element.Effects.First((arg) => arg is ShadowColor);
            var shadowColor = routingEffect.ShadowColorEffect;

            tv.SetShadowLayer(2f, 2f, 2f, shadowColor.ToAndroid());
        }

        protected override void OnDetached()
        {
            var tv = Control as TextView;
            tv.SetShadowLayer(oldRadius, oldDx, oldDy, oldColor);
        }
    }
}