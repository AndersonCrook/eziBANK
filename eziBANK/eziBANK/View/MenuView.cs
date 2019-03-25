using System;

using Xamarin.Forms;

namespace eziBANK.View
{
    public class MenuView : ContentPage
    {
        public MenuView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

