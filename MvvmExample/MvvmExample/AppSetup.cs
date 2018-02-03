using Autofac;
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
            if (AppContainer.Container == null)
            {
                AppContainer.Container = this.CreateContainer();
            }

            // Init Navigation Keys
            if (AppContainer.NavigationKeys == null)
            {
                AppContainer.NavigationKeys = this.CreateNavigationKeys();
            }
        }

        protected IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            this.RegisterDependencies(containerBuilder);
            // Call another with containerBuilder

            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            // View-Models
            cb.RegisterType<MainViewModel>();
            cb.RegisterType<EmailViewModel>();
            cb.RegisterType<DetailViewModel>();

            // Services
            cb.RegisterType<NavigationService>().As<INavigationService>().SingleInstance(); // Must be SingleInstance
            cb.RegisterType<EmailService>().As<IEmailService>().SingleInstance();
        }

        // Create Dictonary<VMType, VType>
        protected IDictionary<Type, Type> CreateNavigationKeys()
        {
            var dictonary = new Dictionary<Type, Type>
            {
                { typeof(MainViewModel), typeof(MainPage) },
                { typeof(EmailViewModel), typeof(EmailPage) },
                { typeof(DetailViewModel), typeof(DetailPage) },
            };

            return dictonary;
        }
    }
}
