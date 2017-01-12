using Xamarin.Forms;

namespace Alpenhorn.Screens
{
    public partial class BeaconNotificationScreen : ContentPage
    {
        public BeaconNotificationScreen()
        {
            InitializeComponent();
            messageBox.BindingContext = new BeaconNotificationScreenModel();
        }
    }
}
