using System;
using System.Windows.Input;
using eziBANK.Services.Navigation;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
     class PrimeiroAcessoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public PrimeiroAcessoViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
        public ICommand Login
        {
            get
            {
                return new Command(() =>
                {
                    _serviceNavigation.NavigateToAsync<LoginViewModel>();
                });
            }
        }
    }
}
