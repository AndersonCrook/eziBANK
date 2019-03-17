﻿using Xamarin.Forms;

namespace eziBANK.Controls
{
   
    public class NavigationBarGradiente : NavigationPage
    {
        public NavigationBarGradiente(Page root) : base(root)
        {
        }

        public static readonly BindableProperty RightColorProperty =
          BindableProperty.Create(propertyName: nameof(RightColor),
              returnType: typeof(Color),
              declaringType: typeof(NavigationBarGradiente),
              defaultValue: Color.Accent);

        public static readonly BindableProperty LeftColorProperty =
           BindableProperty.Create(propertyName: nameof(LeftColor),
               returnType: typeof(Color),
               declaringType: typeof(NavigationBarGradiente),
               defaultValue: Color.Accent);

        public Color RightColor
        {
            get { return (Color)GetValue(RightColorProperty); }
            set { SetValue(RightColorProperty, value); }
        }

        public Color LeftColor
        {
            get { return (Color)GetValue(LeftColorProperty); }
            set { SetValue(LeftColorProperty, value); }
        }
    }
}
