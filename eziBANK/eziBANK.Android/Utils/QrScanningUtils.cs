using System.Threading.Tasks;
using eziBANK.Utils;
using ZXing.Mobile;
using Xamarin.Forms;

[assembly: Dependency(typeof(eziBANK.Droid.Utils.QrScanningUtils))]

namespace eziBANK.Droid.Utils
{
    public class QrScanningUtils : IQrScanningUtils
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Traga a câmera para mais perto do elemento",
                BottomText = "Toque na tela para focar",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}
