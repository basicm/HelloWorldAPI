using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestOutput()
        {
            using (RedirectConsole console = new RedirectConsole())
            {
                IStrategyInterface strategy = WriterFactory.CreateWriter("CONSOLE");
                strategy.Write(@"Hello World!");

                Assert.IsTrue(console.ToString().Contains("Hello World!"));
            }
        }

    }
}
