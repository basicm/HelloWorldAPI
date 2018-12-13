using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class RedirectConsole : IDisposable
    {
        private StringWriter output = new StringWriter();
        private TextWriter _originalConsoleOutput;
        public RedirectConsole()
        {
            this._originalConsoleOutput = Console.Out;
            Console.SetOut(output);
        }
        public void Dispose()
        {
            Console.SetOut(_originalConsoleOutput);
            Console.Write(this.ToString());
            this.output.Dispose();
        }
        public override string ToString()
        {
            return this.output.ToString();
        }
    }
}
