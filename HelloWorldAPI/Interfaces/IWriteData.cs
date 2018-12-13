using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    public interface IWriteData
    {
        Task<bool> WriteAsync(string content);
    }
}
