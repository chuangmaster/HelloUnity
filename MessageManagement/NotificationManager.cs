using MessageManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageManagement
{
    public class NotificationManager : INotificationManager
    {
        private readonly IMessageService _msgService = null;

        public NotificationManager()
        {
            Console.WriteLine(" 呼叫了無參數的建構函式。");
        }
        public NotificationManager(IMessageService svc)
        {
            Console.WriteLine(" 呼叫了一個參數的建構函式。");
        }
        public NotificationManager(IMessageService svc1, IMessageService svc2)
        {
            Console.WriteLine(" 呼叫了兩個參數的建構函式。");
            _msgService = svc1;
        }
        // 利用訊息服務來發送訊息給指定對象。
        public void Notify(string to, string msg)
        {
            _msgService.SendMessage(to, msg);
        }
    }
}
