using UIKit;
using WineShope.Customs;
using WineShope.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomSearch), typeof(CustomSearchBarRenderer))]
namespace WineShope.iOS.Renderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            var searchbar = (UISearchBar)Control;
            if (e.NewElement != null)
            {
                Foundation.NSString _searchField = new Foundation.NSString("searchField");
                var textFieldInsideSearchBar = (UITextField)searchbar.ValueForKey(_searchField);
                textFieldInsideSearchBar.BackgroundColor = UIColor.White;
                textFieldInsideSearchBar.TextColor = UIColor.Gray;

                searchbar.Layer.CornerRadius = 20;
                searchbar.Layer.BorderWidth = 12;
                searchbar.ClipsToBounds = true;
                searchbar.Layer.BackgroundColor = Color.White.ToCGColor();
                searchbar.Layer.BorderColor = Color.White.ToCGColor();
                searchbar.TintColor = UIColor.Gray;
                searchbar.BarTintColor = UIColor.White;
            }
        }
    }
}