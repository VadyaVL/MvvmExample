using MvvmExample.Services;

namespace MvvmExample.ViewModels
{
    public abstract class BasicVm
    {
        protected IEmailService EmailService { get; set; }
    }
}
