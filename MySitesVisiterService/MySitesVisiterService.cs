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
    public partial class MySitesVisiterService : ServiceBase
    {
        public MySitesVisiterService()
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
                if (!EventLog.SourceExists("MySitesVisiterService"))
                {
                    EventLog.CreateEventSource("MySitesVisiterService", "MySitesVisiterServiceLog");
                }
                MyEventLog.Source = "MySitesVisiterService";
                MyEventLog.WriteEntry(logMessage);
            }
            catch
            {

            }
        }
    }
}
