using Autofac;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public MainViewModel Main
        {
            get => AppContainer.Container.Resolve<MainViewModel>();
        }

        public EmailViewModel Email
        {
            get => AppContainer.Container.Resolve<EmailViewModel>();
        }
    }
}