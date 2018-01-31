using Autofac;
using MvvmExample.Services;
using MvvmExample.ViewModels;

namespace MvvmExample
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            this.RegisterDependencies(containerBuilder);
            // Call another with containerBuilder

            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            // View-Models
            cb.RegisterType<EmailVm>();

            // Services
            cb.RegisterType<EmailService>().As<IEmailService>();
        }
    }
}
