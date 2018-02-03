using System;
using System.Threading.Tasks;

namespace MvvmExample.Services
{
    public interface INavigationService
    {
        void SetRootPage(Type vmType, bool isMasterDetail = false);

        Task PushAsync(Type vmType);

        Task PopAsync();
    }
}
