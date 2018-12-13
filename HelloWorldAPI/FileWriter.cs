using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public class FileWriter : WriteData
    {
        private string fileName;

        public FileWriter(string fileName)
        {
            this.fileName = fileName;
        }

        public override bool Write(string content)
        {
            using (FileStream fs = File.Open(this.fileName, FileMode.Append))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(content);
                fs.Write(buffer,0,buffer.Length);
            }
            return true;
        }
    }
}
