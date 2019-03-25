using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Lottie.Forms.Droid;
using Plugin.Fingerprint;
using Plugin.CurrentActivity;
using ZXing.Mobile;

namespace eziBANK.Droid
{
    [Activity(Label = "eziBANK", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static MainActivity context;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //if (Build.VERSION.SdkInt >= Build.VERSION_CODES.Lollipop)
           // {
           //    Window.AddFlags(WindowManagerFlags.LayoutNoLimits);
           //     Window.AddFlags(WindowManagerFlags.LayoutInScreen);
            //    Window.DecorView.SetFitsSystemWindows(true);
           // }

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            context = this;
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            CrossFingerprint.SetCurrentActivityResolver(() => this);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            MobileBarcodeScanner.Initialize(this.Application);
            LoadApplication(new App());
            //CachedImageRenderer.Init(true);
           //AnimationViewRenderer.Init();
        }
    }
}