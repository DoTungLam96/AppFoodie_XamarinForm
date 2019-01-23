using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace FoodieApp.Droid
{
    public class CustomLabelRenderer : LabelRenderer
{
    protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
    {
        base.OnElementChanged(e);

        if (Control != null && Element != null)
        {
            if (((UnderlineText)Element).IsUnderlined)
            {
                Control.PaintFlags = PaintFlags.UnderlineText;
            }
        }
    }
}
}