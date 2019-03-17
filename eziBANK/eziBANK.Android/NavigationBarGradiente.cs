/*using System;
using Android.Graphics.Drawables;
using eziBANK.Controls;
using eziBANK.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(eziBANK.Controls.NavigationBarGradiente), typeof(eziBANK.Controls.NavigationBarGradiente))]
namespace eziBANK.Droid
{
    public class NavigationBarGradiente : NavigationRenderer
    {
        private object RightColor;

        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);

            //run once when element is created
            if (e.OldElement != null || Element == null)
            {
                return;
            }

            var control = (NavigationBarGradiente)this.Element;
            var context = (MainActivity)this.Context;

            context.ActionBar.SetBackgroundDrawable(new GradientDrawable(GradientDrawable.Orientation.RightLeft, new int[] { control.RightColor.ToAndroid(), control.LeftColor.ToAndroid() }));
        }

   }
}*/