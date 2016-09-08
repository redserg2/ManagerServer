using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;
using System.Configuration;
using SqlDBConnector;
using System.Diagnostics;

namespace TestApplication1
{
    //class DataUOW:IDataUOW{};
    class Program
    {
        static void Main(string[] args)
        {

            Debugger.Launch();
            //var my_assembly = Assembly.Load();

            using (IDataUOW uow = new DataUOW())
            {
                //uow.Users.Insert(new User() { name = String.Format("User{0}", new Random().Next()) });
                //uow.Save();
                foreach (User i in uow.Users.Get())
                {
                    
                }
            }

           
            //using (IDataUOW uow = new DataUOW())
            //{
            //    uow.Users.Insert(new User() { name = String.Format("User{0}", new Random().Next()) });
            //    uow.Save();
            //    foreach (User i in uow.Users.Get())
            //    {
                     
            //    }
            //}
        }
    }
}
