using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MyAffirmationServiceLib;



namespace PositiveAffirmationsHost
{
    public partial class PositiveAffirmationService : ServiceBase
    {
        private ServiceHost mHost = null;

        public PositiveAffirmationService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                // Initialize the Service
                mHost = new ServiceHost(typeof(AffirmationService));
                // Start The Service Hosting
                mHost.Open();
                EventLog.WriteEntry("AffirmationWindowsServiceHost", "The Affirmention Service Successfully Started!", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("AffirmationWindowsServiceHost", "Failed to start " + ex.Message, EventLogEntryType.Error);
            }
        }

        protected override void OnStop()
        {
            try
            {
                // Stop The Service Hosting
                if(mHost != null)
                {
                    mHost.Close();
                }

                EventLog.WriteEntry("AffirmationWindowsServiceHost", "The Affirmention Service Successfully Stopped", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("AffirmationWindowsServiceHost", "Failed to stop " + ex.Message, EventLogEntryType.Error);
            }
        }
    }
}
