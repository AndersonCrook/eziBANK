using GalaSoft.MvvmLight;
using System.Threading.Tasks;

namespace eziBANK.ViewModel
{
    public class BaseVM : ViewModelBase
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
