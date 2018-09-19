using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace MessageManagement.Interceptions
{
    public class MyFirstLoggerBehavior : IInterceptionBehavior
    {
        public bool WillExecute { get { return true; } }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return new Type[] { };
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            // 呼叫⽬標⽅法之前。
            Console.WriteLine(" 正要執行此方法：{0}", input.MethodBase.Name);
            // 呼叫攔截管線中的下⼀個攔截⾏為。
            var result = getNext()(input, getNext);
            // 呼叫⽬標⽅法之後。
            Console.WriteLine(" 正要離開此方法：{0}", input.MethodBase.Name);
            return result;
        }
    }
}
