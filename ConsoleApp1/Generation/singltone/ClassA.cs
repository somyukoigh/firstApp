using ConsoleApp1.Generation.singltone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal class ClassA : ILogger 
    {
        ILogger logger;
        public ClassA()
        {
            Logger log = Logger.GetInstance();
            log.Log("Class A was init");

            Console.WriteLine(log.GetHashCode());
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
//i lov nulokjl;k;
