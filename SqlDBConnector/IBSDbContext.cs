using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataModel;

namespace SqlDBConnector
{
    public class STDbContext
    {
        private static ManagerDatabaseContainer _MDContext;
        private static object _lockFild=new object();
        private static int _ref;
        private static Timer _t;

        public STDbContext()
        {
            lock (_lockFild)
            {
                if(_t!=null)_t.Dispose();
                if (_MDContext == null) _MDContext = new ManagerDatabaseContainer();
                _ref++;
            }
        }

        ~STDbContext()
        {
            lock(_lockFild)
            {
                if (_ref > 1) _ref--;
                else
                {
                    _t = new Timer(ObjectDispose, null, 60000, Timeout.Infinite);
                }
            }
        }

        static void ObjectDispose(object obj)
        {
            lock (_t)
            {
                _MDContext.Dispose();
                
            }
        }
    }
}
