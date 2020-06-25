using Plugin.SharedTransitions;
using WineShope.Views;
using Xamarin.Forms;

namespace WineShope
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
