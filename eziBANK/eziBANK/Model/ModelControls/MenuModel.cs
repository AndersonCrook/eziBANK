using System;

using Xamarin.Forms;

namespace eziBANK.Model.ModelControls
{
    public class MenuModel : ContentPage
    {
        public MenuModel()
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

