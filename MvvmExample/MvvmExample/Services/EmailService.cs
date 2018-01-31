using MvvmExample.Models;

namespace MvvmExample.Services
{
    public class EmailService : IEmailService
    {
        public bool Send(EmailDto data)
        {
            return true;
        }
    }
}
