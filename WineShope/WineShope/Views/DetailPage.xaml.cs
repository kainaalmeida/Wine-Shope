using WineShope.Models;
using WineShope.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WineShope.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private readonly DetailPageViewModel ViewModel;
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = new DetailPageViewModel(Navigation);
        }

        public DetailPage(Wine wine) : this()
        {
            ViewModel.Wine = wine;
        }
    }
}