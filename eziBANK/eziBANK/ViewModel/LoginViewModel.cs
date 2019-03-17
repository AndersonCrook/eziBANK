﻿using eziBANK.Model;
using eziBANK.Services;
using eziBANK.Services.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
    class LoginViewModel : BaseVM
    {
        LoginService loginService;
        INavigationService _serviceNavigation;
        public LoginViewModel(INavigationService serviceNavigation)
        {
            loginService = new LoginService();
            _serviceNavigation = serviceNavigation;
        }
        
        public ICommand LogarCommand
        {
            get
            {
                return new Command(() =>
                {
                    Logar();
                });
            }
        }

        public async void Logar()
        {
            LoginModel model = new LoginModel();
            if (!string.IsNullOrEmpty(this.Usuario) && !string.IsNullOrEmpty(this.Senha))
            {
                model.Usuario = this.Usuario;
                model.Senha = this.Senha;

                //var result = await service.Logar(model);
                //if (result)
                //await _serviceNavigation.NavigateToAsync<HomeViewModel>();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Treinamento", "Usuario ou senha nao podem ser vazios", "Ok");
            }
        }

        private string usuario = string.Empty;
        public string Usuario { get { return usuario; } set { this.Set("Usuario", ref usuario, value); } }

        private string senha = string.Empty;
        public string Senha { get { return senha; } set { this.Set("Senha", ref senha, value); } }
    }
}
