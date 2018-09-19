using MessageManagement.Interceptions;
using MessageManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.RegistrationByConvention;

namespace MessageManagement
{
    class Program
    {
        static void Main(string[] args)
        {
var container = new UnityContainer();
            //container.RegisterTypes(
            //    types: AllClasses.FromLoadedAssemblies(), // 掃描目前已經載入此應用程式的全部組件。
            //    getFromTypes: WithMappings.FromAllInterfaces, // 尋找所有介面。
            //    getName: WithName.TypeName);  // 取得特定類別的註冊名稱。
            //container.RegisterType<IMessageService, EmailService>("email",
            //    new InjectionConstructor("xxx@gmail.com")
            //    );
            //container.RegisterType<IMessageService, SmsService>("sms");

            //container.RegisterType<INotificationManager, NotificationManager>(
            //    new InjectionConstructor(
            //    new ResolvedParameter<IMessageService>("email"),
            //    new ResolvedParameter<IMessageService>("sms")
            //    )
            //);

            //var svc = container.Resolve<IMessageService>("email");
            //svc.SendMessage("Master", "Hello there");

            //var svc = container.Resolve<INotificationManager>();
            //svc.Notify("Master", "Hello there");
            container.AddNewExtension<Interception>();

            
            container.RegisterType<IMessageService, EmailService>(
                "MailService",
                new Interceptor(new InterfaceInterceptor()),
                new InterceptionBehavior(typeof(MyFirstLoggerBehavior), "FirstLogger"),
                new InterceptionBehavior(typeof(MySecondLoggerBehavior), "SecondLogger")
                );

            container.RegisterType<IMessageService, LineService>(
             "LineService",
             new Interceptor(new InterfaceInterceptor()),
             new InterceptionBehavior(typeof(MyFirstLoggerBehavior), "FirstLogger"),
             new InterceptionBehavior(typeof(MySecondLoggerBehavior), "SecondLogger")
             );

            var svc = container.Resolve<IMessageService>("MailService");
            var svcLine = container.Resolve<IMessageService>("LineService");
            svc.SendMessage("Master", "Hello");
            svc.ReceiveMessage();
            Console.WriteLine("---------------");
            svcLine.SendMessage("Helga", "Hi");
            svcLine.ReceiveMessage();
            Console.Read();
        }
    }
}
