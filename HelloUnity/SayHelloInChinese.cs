using HelloUnity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUnity
{
    class SayHelloInChinese : ISayHello
    {
        public void Run()
        {
            Console.WriteLine(" 哈囉, Unity!");
        }
    }
}
