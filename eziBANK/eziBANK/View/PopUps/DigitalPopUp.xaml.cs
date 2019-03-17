using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace eziBANK.View.PopUps
{
    public partial class DigitalPopUp : PopupPage
    {
        public DigitalPopUp()
        {
            InitializeComponent();

            // MinhasGestantesModel gestante = model as MinhasGestantesModel;
            // lblNome.Text = gestante.Nome;
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {

            await PopupNavigation.PushAsync(new Loading(), true);
            await Task.Delay(6000);
            await DisplayAlert("Febrasgo", "Excluido com sucesso!", "Fechar");

        }

        async void Handle_Tapped_1(object sender, System.EventArgs e)
        {
            await DisplayAlert("Febrasgo", "Abrindo calculadora", "Fechar");
        }

        async void Handle_Tapped_2(object sender, System.EventArgs e)
        {
            await DisplayAlert("Febrasgo", "Compartilhar", "Fechar");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Close();
        }

        private async void Close()
        {
            await Navigation.RemovePopupPageAsync(this);
        }
    }
}
