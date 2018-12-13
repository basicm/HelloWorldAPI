using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public class ConsoleWriter : WriteData
    {
        public override bool Write(string content)
        {
            try
            {
                Console.WriteLine(content);
                Console.ReadLine();
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
