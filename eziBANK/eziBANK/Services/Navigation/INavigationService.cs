using eziBANK.ViewModel;
using System;
using System.Threading.Tasks;

namespace eziBANK.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync(Type viewModelType);
    }
}
