using Autofac;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public EmailVm Email
        {
            get => AppContainer.Container.Resolve<EmailVm>();
        }
    }
}