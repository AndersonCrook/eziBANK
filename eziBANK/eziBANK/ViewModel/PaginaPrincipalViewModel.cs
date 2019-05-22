using System;
using System.Windows.Input;
using eziBANK.Services.Navigation;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
    public class PaginaPrincipalViewModel : BaseVM
    {
        INavigationService _serviceNavigation;

        public PaginaPrincipalViewModel(INavigationService serviceNavigation)
        {
            SaldoAtual = "7.000,00";
            _serviceNavigation = serviceNavigation;
        }

        public ICommand EsconderCommand
        {
            get
            {
                return new Command(() =>
                {
                    EsconderSaldo();
                });
            }
        }

        private void EsconderSaldo()
        {
            if (SaldoAtual == "--")
            {
                SaldoAtual = "7.000,00";
            }
            else
            {
                SaldoAtual = "--";
            }
        }

        private string saldoAtual;
        public string SaldoAtual { get { return saldoAtual; } set { this.Set("SaldoAtual", ref saldoAtual, value); } }
    }
}