using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Interfaces
{
    public interface INotificationService
    {
        public void SendNotification(string recipient,String Message );


    }
}
