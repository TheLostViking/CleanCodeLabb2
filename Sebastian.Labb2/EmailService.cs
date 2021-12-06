using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian.Labb2
{
    public class EmailService : IEmailService, ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        public void SendEmail(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            LogMessage($"Notification sent to email {email} for order {ID}");
        }
    }
}
