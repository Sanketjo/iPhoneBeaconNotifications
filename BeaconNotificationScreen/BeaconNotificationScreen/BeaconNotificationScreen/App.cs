using Alpenhorn.Screens;
using Xamarin.Forms;

namespace Alpenhorn
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new BeaconNotificationScreen());
        }
    }
}
