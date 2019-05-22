using System;
using System.Windows.Input;
using DLToolkit.Forms.Controls;
using eziBANK.Model;
using eziBANK.Services;
using eziBANK.Services.Navigation;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
    public class MenuViewModel : BaseVM
    {
        MenuService service;
        public FlowObservableCollection<MenuModel> ItensMenu { get; set; }
        INavigationService _serviceNavigation;
        public MenuViewModel(INavigationService serviceNavigation)
        {
            ItensMenu = new FlowObservableCollection<MenuModel>();
            service = new MenuService();
            _serviceNavigation = serviceNavigation;
            CarregarMenu();
        }

        public void CarregarMenu()
        {
            var collection = service.GetItensMenu();
            foreach (var item in collection)
            {
                ItensMenu.Add(item);
            }
        }

        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async (value) =>
                {
                    MenuModel item = value as MenuModel;
                    switch (item.Id)
                    {
                        case 1:
                            await _serviceNavigation.NavigateToAsync<PagamentoViewModel>();
                            break;

                        case 2:
                            await _serviceNavigation.NavigateToAsync<PagamentoViewModel>();
                            break;

                        case 3:
                            await _serviceNavigation.NavigateToAsync<PagamentoViewModel>();
                            break;
                        case 4:
                            await _serviceNavigation.NavigateToAsync<PagamentoViewModel>();
                            break;
                        case 5:
                            await _serviceNavigation.NavigateToAsync<LoginViewModel>();
                            break;
                        default:
                            break;
                    }
                });
            }
        }
    }
}
