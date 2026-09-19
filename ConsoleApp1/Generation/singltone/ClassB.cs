using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal class ClassB : ILogger 
    {
        public Logger log;
        public ClassB()
        {
            log = Logger.GetInstance();
            log.Log("Class B was init");

            Console.WriteLine(log.GetHashCode());
        }
    }
}
