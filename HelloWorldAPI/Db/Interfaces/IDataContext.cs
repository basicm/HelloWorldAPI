using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Db.Interfaces
{
    public interface IDataContext : IDisposable
    {
        void Add(object item);
        void Save(object item);
        void Delete(object item);

        IList<T> GetAll<T>() where T : class, new();
        IList<T> GetByCriteria<T>(string query) where T : class, new();
        Task GetById<T>(object id) where T : class, new();
    }
}
