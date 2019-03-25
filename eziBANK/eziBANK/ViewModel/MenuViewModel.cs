using System;
using System.Windows.Input;
using eziBANK.Services.Navigation;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
    public class MenuViewModel : BaseVM
    {

        INavigationService _serviceNavigation;

        public MenuViewModel()
        {
        }

        public MenuViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
         public ICommand Navegar
        {
            get
            {
                return new Command(() =>
                {
                    voltar();
                });
            }
        }

        public async void voltar()
        {
            await _serviceNavigation.NavigateToAsync<PagamentoViewModel>();
        }
    }

}
