using MvvmExample.Models;

namespace MvvmExample.Services
{
    public interface IEmailService
    {
        bool Send(EmailDto data);
    }
}
