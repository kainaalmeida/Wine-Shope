using System;
using System.Threading.Tasks;
using WineShope.Models;
using Xamarin.Forms;

namespace WineShope.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private Wine _wine;
        public Wine Wine
        {
            get { return _wine; }
            set { SetProperty(ref _wine, value); }
        }

        public Command CloseCommand { get; }

        public DetailPageViewModel(INavigation navigation) : base(navigation)
        {
            CloseCommand = new Command(async () => await ExecuteCloseCommand());
        }

        private async Task ExecuteCloseCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
