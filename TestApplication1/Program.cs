using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDBConnector;
using DataModel;

namespace TestApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IDataUOW uow = new DataUOW())
            {
                foreach (User i in uow.Users.GetAll())
                {
                    Console.WriteLine("{0}",i.name);
                }
            }
        }
    }
}
