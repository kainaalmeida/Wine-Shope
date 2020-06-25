using System.Collections.ObjectModel;
using WineShope.Models;

namespace WineShope.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Wine> Wines { get; } = new ObservableCollection<Wine>();
        public MainPageViewModel()
        {
            LoadWines();
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
