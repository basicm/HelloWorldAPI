using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Db.Interfaces
{
    public interface IDataProviderFactory
    {
        IDataContext GetDataContext();
    }
}
