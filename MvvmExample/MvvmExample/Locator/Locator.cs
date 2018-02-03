using Autofac;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public MainViewModel Main => AppContainer.Container.Resolve<MainViewModel>();

        public EmailViewModel Email  => AppContainer.Container.Resolve<EmailViewModel>();

        public DetailViewModel Detail => AppContainer.Container.Resolve<DetailViewModel>();
    }
}