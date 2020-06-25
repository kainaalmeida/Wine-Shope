using Plugin.SharedTransitions;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WineShope.Models;
using WineShope.Views;
using Xamarin.Forms;

namespace WineShope.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Wine> Wines { get; } = new ObservableCollection<Wine>();

        private Wine _wineSelected;
        public Wine WineSelected
        {
            get { return _wineSelected; }
            set { SetProperty(ref _wineSelected, value); }
        }

        private int _wineSelectedId;
        public int WineSelectedId
        {
            get { return _wineSelectedId; }
            set { SetProperty(ref _wineSelectedId, value); }
        }


        public Command<Wine> DetailCommand { get; }

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            LoadWines();
            DetailCommand = new Command<Wine>(async (item) => await ExecuteDetailCommand(item));
        }

        private async Task ExecuteDetailCommand(Wine item)
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;
                WineSelectedId = item.Id;
                await Navigation.PushAsync(new DetailPage(item));
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }

        void LoadWines()
        {
            Wines.Add(new Wine(1, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img01.png"));
            Wines.Add(new Wine(2, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img02.png"));
            Wines.Add(new Wine(3, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img02.png"));
            Wines.Add(new Wine(4, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img03.png"));
            Wines.Add(new Wine(5, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img03.png"));
            Wines.Add(new Wine(6, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img01.png"));
            Wines.Add(new Wine(7, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img02.png"));
            Wines.Add(new Wine(8, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img02.png"));
            Wines.Add(new Wine(9, "White Wine", "Model 2013", "$99", "4.5", "4.5", "img03.png"));
        }
    }
}
