using FreshMvvm;
using MvvmExample.Services;
using MvvmExample.ViewModels;
using MvvmExample.Views;
using System;
using System.Collections.Generic;

namespace MvvmExample
{
    public class AppSetup
    {
        private static AppSetup _instance;

        private bool _isIocInitialize;

        public static AppSetup Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new AppSetup();
                }

                return _instance;
            }
        }

        private AppSetup()
        {

        }

        public void InitializeApp()
        {
            if (!_isIocInitialize)
            {
                this.InitIoC();
            }

            // Init Navigation Keys
            if (AppContainer.NavigationKeys == null)
            {
                AppContainer.NavigationKeys = this.CreateNavigationKeys();
            }
        }

        private void InitIoC()
        {
            // View-Models
            FreshIOC.Container.Register<MainViewModel>();
            FreshIOC.Container.Register<UserViewModel>().AsSingleton();
            FreshIOC.Container.Register<EmailViewModel>();
            FreshIOC.Container.Register<DetailViewModel>();
            FreshIOC.Container.Register<SettingViewModel>();

            // Services
            FreshIOC.Container.Register<NavigationService>().As<INavigationService>().AsSingleton(); // Must be SingleInstance
            FreshIOC.Container.Register<EmailService>().As<IEmailService>();
        }

        // Create Dictonary<VMType, VType>
        protected IDictionary<Type, Type> CreateNavigationKeys()
        {
            var dictonary = new Dictionary<Type, Type>
            {
                { typeof(MainViewModel), typeof(MainPage) },
                { typeof(UserViewModel), typeof(UserPage) },
                { typeof(EmailViewModel), typeof(EmailPage) },
                { typeof(DetailViewModel), typeof(DetailPage) },
                { typeof(SettingViewModel), typeof(SettingPage) },
            };

            return dictonary;
        }
    }
}
