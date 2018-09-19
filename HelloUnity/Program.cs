using HelloUnity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace HelloUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ISayHello, SayHelloInChinese>();
            container.RegisterType<ISayHello, SayHelloInChinese>("");
            container.RegisterType<ISayHello, SayHelloInChinese>("CH");
            container.RegisterType<ISayHello, SayHelloInEnglish>();
            //container.RegisterInstance<ISayHello>(new SayHelloInEnglish());
            //ISayHello hello = container.Resolve<ISayHello>();
            foreach (var item in container.Registrations)
            {
                Console.WriteLine($"Name:{item.Name} , Register:{item.RegisteredType}, MappedToType:{item.MappedToType}");
            }
            //hello.Run();
            Console.Read();
        }
    }
}
