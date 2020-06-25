using WineShope.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WineShope.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}