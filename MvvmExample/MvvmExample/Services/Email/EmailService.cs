using MvvmExample.Models;
using System.Diagnostics;

namespace MvvmExample.Services
{
    public class EmailService : IEmailService
    {
        public bool Send(EmailDto data)
        {
#if DEBUG
            Debug.WriteLine("Send: " + data.ToString());
#endif
            return true;
        }
    }
}
