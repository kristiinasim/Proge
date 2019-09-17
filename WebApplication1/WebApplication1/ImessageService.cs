using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface IMessageService
    {
        void Send(string message);
    }

    public class Mailer : IMessageService
    {
        public void Send(string message)
        {
            Debug.WriteLine("Mailer: " + message);
        }
    }

    public class SmsMessenger : IMessageService
    {
        public void Send(string message)
        {
            Debug.WriteLine("SMS: " + message);
        }
    }
}

