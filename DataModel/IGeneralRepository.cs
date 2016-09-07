using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IGeneralRepository<T>
    {
        T FindById(object id);
        List<T> GetAll();
        void Save(T Entity);
    }
}
