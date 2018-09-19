using MessageManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace MessageManagement
{
    public class EmailService : IMessageService
    {
        [InjectionConstructor]
        public EmailService()
        {

        }
        public EmailService(string addr)
        {
            Console.WriteLine("Mail Address : {0}", addr);
        }

        public void ReceiveMessage()
        {
            Console.WriteLine(" 透過 EmailService收到信囉...");
        }

        public void SendMessage(string to, string msg)
        {
            Console.WriteLine(" 透過 EmailService 發送郵件給 {0}。", to);
        }
    }
}
