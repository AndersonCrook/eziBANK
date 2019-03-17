using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;

namespace eziBANK.View.PopUps
{
    public partial class Loading 
    {
        public Loading()
        {
            InitializeComponent();
            CloseLoadin();
        }

        private async void CloseLoadin()
        {
            //var loadingPage = new Loading();

            await Task.Delay(3000);
            await Navigation.RemovePopupPageAsync(this);
        }
    }
}
