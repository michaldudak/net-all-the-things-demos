using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Library;

namespace WindowsPhoneApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private async void TheButton_OnClick(object sender, RoutedEventArgs e)
        {
            var greeter = new Greeter();
            var dialog = new MessageDialog(greeter.Greet());

            await dialog.ShowAsync();
        }
    }
}
