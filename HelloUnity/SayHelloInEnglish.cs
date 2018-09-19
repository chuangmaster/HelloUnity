using HelloUnity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUnity
{
    class SayHelloInEnglish : ISayHello
    {
        public void Run()
        {
            Console.WriteLine("Hello, Unity!");
        }
    }
}
