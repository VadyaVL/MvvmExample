using FreshMvvm;
using MvvmExample.ViewModels;

namespace MvvmExample.Locator
{
    public class Locator
    {
        public MainViewModel Main => FreshIOC.Container.Resolve<MainViewModel>();

        public UserViewModel User => FreshIOC.Container.Resolve<UserViewModel>();

        public EmailViewModel Email  => FreshIOC.Container.Resolve<EmailViewModel>();

        public DetailViewModel Detail => FreshIOC.Container.Resolve<DetailViewModel>();

        public SettingViewModel Setting => FreshIOC.Container.Resolve<SettingViewModel>();
    }
}