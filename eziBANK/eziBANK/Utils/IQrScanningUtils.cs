using System.Threading.Tasks;

namespace eziBANK.Utils
{
    public interface IQrScanningUtils 
    {
            Task<string> ScanAsync();
    }
}

