using MessageManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageManagement
{
    public class TelgramService : IMessageService
    {
        public void ReceiveMessage()
        {
            Console.WriteLine(" 透過 TelgramService收到訊息囉...");
        }

        public void SendMessage(string to, string msg)
        {
            Console.WriteLine(" 透過 TelgramService 發送簡訊給 {0}。", to);

        }
    }
}
