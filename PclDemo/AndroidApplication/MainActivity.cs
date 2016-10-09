using Android.App;
using Android.Widget;
using Android.OS;
using Library;

namespace AndroidApplication
{
    [Activity(Label = "AndroidApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += (s, e) =>
            {
                var greeter = new Greeter();
                button.Text = greeter.Greet();
            };
        }
    }
}
