using Autofac;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public Locator()
        {

        }

        public MainViewModel Main => AppContainer.Container.Resolve<MainViewModel>();

        public UserViewModel User => AppContainer.Container.Resolve<UserViewModel>();

        public EmailViewModel Email  => AppContainer.Container.Resolve<EmailViewModel>();

        public DetailViewModel Detail => AppContainer.Container.Resolve<DetailViewModel>();

        public SettingViewModel Setting => AppContainer.Container.Resolve<SettingViewModel>();
    }
}