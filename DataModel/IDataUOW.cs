using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IDataUOW : IDisposable
    {
        IUserRepository Users { get; }

        IGroupRepository Groups{get;}
    }
}
