using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageManagement.Interfaces
{
    public interface IMessageService
    {
        void SendMessage(string to, string msg);
        void ReceiveMessage();
    }
}
