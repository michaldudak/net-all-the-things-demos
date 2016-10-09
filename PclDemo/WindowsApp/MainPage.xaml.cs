using Windows.UI.Xaml.Controls;
using Library;

namespace WindowsApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var greeter = new Greeter();

            MyTextBlock.Text = greeter.Greet();
        }
    }
}
