using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GMSvc
{
    public partial class MainService : ServiceBase
    {
        
        public MainService()
        {
            string sSource="GMService";
            InitializeComponent();
            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource,"Application");
        }

        protected override void OnStart(string[] args)
        {
            Thread thread = new Thread(Threads.TestThread);
            thread.Start(this);

        }

        

        protected override void OnStop()
        {
            EventLog.WriteEntry("Service stoped");
        }
    }
}
