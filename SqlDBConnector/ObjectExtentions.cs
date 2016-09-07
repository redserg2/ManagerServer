using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDBConnector
{
    public static class ObjectExtensions
    {
        public static void CheckNotNull(this object value, string error)
        {
            if (value == null)
                throw new Exception(error);
        }
    }
}
