using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WineShope.Customs;
using WineShope.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSearch),typeof(CustomSearchBarRenderer))]
namespace WineShope.Droid.Renderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        public CustomSearchBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

			GradientDrawable shape = new GradientDrawable();
            shape.SetColor(global::Android.Graphics.Color.White);
            shape.SetShape(ShapeType.Rectangle);
			shape.SetCornerRadius(50);
			this.Control.SetPadding(15, 20, 15, 20);
			this.Control.SetBackground(shape);

            var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
            var plate = Control.FindViewById(plateId);
            plate.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}