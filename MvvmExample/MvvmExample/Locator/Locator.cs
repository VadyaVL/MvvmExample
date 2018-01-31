using Autofac;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public EmailVm EmailVm
        {
            get => AppContainer.Container.Resolve<EmailVm>();
        }
    }
}