using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eziBANK.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : MasterDetailPage
    {
        public MenuView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}
