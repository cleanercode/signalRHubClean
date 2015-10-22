using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davidhartmanninfo.FireIncidentRealtime.ServiceBus
{
    /// <summary>
    /// Service Bus for fire incident notification
    /// </summary>
    public class FireIncidentNotify
    {
        /// <summary>
        /// A fire incident occured
        /// </summary>
        public event EventHandler<davidhartmanninfo.FireIncidentRealtime.Models.FireIncident> FireIncident;

        /// <summary>
        /// Raise fire incident event
        /// </summary>
        /// <param name="fireIncident">The created fire incident</param>
        public void Raise(davidhartmanninfo.FireIncidentRealtime.Models.FireIncident fireIncident)
        {
            if (FireIncident != null)
                FireIncident(this, fireIncident);
        }

        /// <summary>
        /// Is somebody already handling the event?
        /// </summary>
        public bool IsRegistered
        {
            get
            {
                return FireIncident != null;
            }
        }
    }
}