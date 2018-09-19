using MessageManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace MessageManagement.Interceptions
{
    public class MySecondLoggerBehavior : IInterceptionBehavior
    {
        public bool WillExecute { get { return true; } }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return new List<Type>() { typeof(IMessageService) };
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            // 呼叫⽬標⽅法之前。
            Console.WriteLine(" 正要執行此攔截：{0}", input.MethodBase.Name);
            // 呼叫攔截管線中的下⼀個攔截⾏為。
            var result = getNext()(input, getNext);
            // 呼叫⽬標⽅法之後。
            Console.WriteLine(" 正要離開此攔截：{0}", input.MethodBase.Name);
            return result;
        }
    }
}
