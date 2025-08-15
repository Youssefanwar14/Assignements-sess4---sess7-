using Assignements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Classes
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string Message)
        {
            Console.WriteLine($"Push Notification sent to {recipient}, {Message}");
        }
    }
}
