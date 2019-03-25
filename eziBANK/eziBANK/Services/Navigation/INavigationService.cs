using System;
using System.Threading.Tasks;
using eziBANK.ViewModel;
using Xamarin.Forms;

namespace eziBANK.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : BaseVM;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseVM;

        Task NavigateToAsync(Type viewModelType);
        Page CreateAndBindPage(Type viewModelType, object parameter);
    }
}