using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public class WriterFactory
    {
        static ObjectFactory objectFactory = new ObjectFactory("Configs.xml");
        public static IStrategyInterface CreateWriter(string type)
        {
            IStrategyInterface strategy = (IStrategyInterface)objectFactory.GetTypeInstance(type);
            return strategy != null ? strategy : new WriteToConsoleStrategy();
        }
    }
}
