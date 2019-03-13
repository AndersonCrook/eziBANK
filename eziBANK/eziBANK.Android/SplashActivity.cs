using Android.App;
using Android.Support.V7.App;
using eziBANK.Droid;

namespace ProjetoVagas.Droid
{
    [Activity(Label = "eziBANK", Icon = "@drawable/icon", Theme = "@style/splashscreen", MainLauncher = true, NoHistory = true)]
    class SplashActivity : AppCompatActivity
    {

        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(typeof(MainActivity));
        }
    }
}