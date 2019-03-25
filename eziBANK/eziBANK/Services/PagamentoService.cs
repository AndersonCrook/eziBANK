using System;
using System.Threading.Tasks;
using eziBANK.Model;
using eziBANK.Utils;
using Xamarin.Forms;

namespace eziBANK.Services
{
    public class PagamentoService
    {
        public async Task<string> Scannear(ScannerCodigoBarras model)
        {
            var response = "";
            try
            {
                var scanner = DependencyService.Get<IQrScanningUtils>();
                response = await scanner.ScanAsync();
                if (response != null)
                {
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }
    }
}
