using System;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace eziBANK.View.PopUps
{
    public partial class DigitalPopUp : PopupPage
    {
        public DigitalPopUp( Page root = null)
        {
            InitializeComponent();
            // MinhasGestantesModel gestante = model as MinhasGestantesModel;
            // lblNome.Text = gestante.Nome;
            btnCancelar.Clicked += Cancelar;

        }

        async void Cancelar(object sender, EventArgs args)
        {
            Close();
        }

        private async void Close()
        {
            await Navigation.RemovePopupPageAsync(this);
        }
    }
}
