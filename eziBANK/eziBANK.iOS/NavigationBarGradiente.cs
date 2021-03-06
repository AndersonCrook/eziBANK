﻿using CoreAnimation;
using CoreGraphics;
using eziBANK.Controls;
using GradientNavigationHeader.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationBarGradiente), typeof(NavigationPageGradientHeaderRenderer))]
namespace GradientNavigationHeader.iOS
{
    public class NavigationPageGradientHeaderRenderer : NavigationRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var control = (NavigationBarGradiente)this.Element;

            var gradientLayer = new CAGradientLayer();
            gradientLayer.Bounds = NavigationBar.Bounds;
            gradientLayer.Colors = new CGColor[] { control.RightColor.ToCGColor(), control.LeftColor.ToCGColor() };
            gradientLayer.StartPoint = new CGPoint(0.0, 0.5);
            gradientLayer.EndPoint = new CGPoint(1.0, 0.5);

            UIGraphics.BeginImageContext(gradientLayer.Bounds.Size);
            gradientLayer.RenderInContext(UIGraphics.GetCurrentContext());
            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();

            NavigationBar.SetBackgroundImage(image, UIBarMetrics.Default);
        }
    }
}