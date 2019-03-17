using System;
using eziBANK.Services.Navigation;

namespace eziBANK.ViewModel
{
     class PrimeiroAcessoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public PrimeiroAcessoViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
