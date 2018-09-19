using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageManagement.Interfaces
{
    interface INotificationManager
    {
        void Notify(string to, string msg);
    }
}
