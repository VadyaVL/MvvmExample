using Autofac;
using MvvmExample.Services;
using MvvmExample.ViewModels;

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

            // Services
            cb.RegisterType<EmailService>().As<IEmailService>();
        }
    }
}
