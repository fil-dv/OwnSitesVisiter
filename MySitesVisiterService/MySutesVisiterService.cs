using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MySitesVisiterService
{
    public partial class MySutesVisiterService : ServiceBase
    {
        public MySutesVisiterService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            AddLog("Service started.");
        }

        protected override void OnStop()
        {
            AddLog("Service stopped.");
        }

        void AddLog(string logMessage)
        {
            try
            {
                if (!EventLog.SourceExists("VisitService"))
                {
                    EventLog.CreateEventSource("VisitService", "VisitServiceLog");
                }
                MyEventLog.Source = "VisitService";
                MyEventLog.WriteEntry(logMessage);
            }
            catch
            {

            }
        }
    }
}
