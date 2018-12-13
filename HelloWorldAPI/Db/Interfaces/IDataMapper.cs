using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Db.Interfaces
{
    public interface IDataMapper<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        IList<T> GetAll();
        IList<T> GetByCriteria(string query);
        T GetById(object id);
    }
}
