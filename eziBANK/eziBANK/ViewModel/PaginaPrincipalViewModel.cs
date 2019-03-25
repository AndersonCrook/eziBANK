using System;
using eziBANK.Services.Navigation;

namespace eziBANK.ViewModel
{
    public class PaginaPrincipalViewModel : BaseVM
    {
        INavigationService _serviceNavigation;

        public PaginaPrincipalViewModel()
        {
        }

        public PaginaPrincipalViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
    }
}
