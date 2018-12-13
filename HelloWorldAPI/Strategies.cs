using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{

    public class WriteToFileStrategy : IStrategyInterface
    {
        public bool Write(string text)
        {
            Console.WriteLine(text);
            return true;
        }
    }
    public class WriteToDbStrategy : IStrategyInterface
    {
        WriteData dbWriter = new DatabaseWriter();

        public bool Write(string content)
        {
            throw new NotImplementedException();
        }
    }

    public class WriteToConsoleStrategy : IStrategyInterface
    {
        WriteData consoleWriter = new ConsoleWriter();

        public bool Write(string content)
        {
            consoleWriter.Write(content);
            return true;
        }
    }
}
