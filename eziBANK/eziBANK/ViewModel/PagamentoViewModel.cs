using System;
using System.Windows.Input;
using eziBANK.Model;
using eziBANK.Services;
using eziBANK.Services.Navigation;
using eziBANK.Utils;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
    public class PagamentoViewModel : BaseVM
    {
        PagamentoService _pagamentoservice;
        INavigationService _serviceNavigation;
        public PagamentoViewModel(INavigationService serviceNavigation)
        {
            _pagamentoservice = new PagamentoService();
            _serviceNavigation = serviceNavigation;
        }

        public ICommand AtivarScanner
        {
            get
            {
                return new Command(() =>
                {
                    Scanner();
                });
            }
        }

        public async void Scanner()
        {

            ScannerCodigoBarras model = new ScannerCodigoBarras();

                model.CodigoBarras = this.CodigoBarras;

                CodigoBarras = await _pagamentoservice.Scannear(model);
        }

        private string codigoBarras = string.Empty;
        public string CodigoBarras { get { return codigoBarras; } set { this.Set("CodigoBarras", ref codigoBarras, value); } }
    }
}
