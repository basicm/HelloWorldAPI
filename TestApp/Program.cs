using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"Hello World!";

            IStrategyInterface strategy = WriterFactory.CreateWriter("CONSOLE");
            strategy.Write(str);
        }
    }
}
