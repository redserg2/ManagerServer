using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GMSvc
{
    class Threads
    {
        public static void TestThread(object obj)
        {
            MainService svc = (MainService)obj;
            svc.EventLog.WriteEntry("Thread start");
            
            
            while (!Debugger.IsAttached)
            {

            }

            Debugger.Break();
            while (true)
            {
                Thread.Sleep(20000);
            }
        }
    }
}
