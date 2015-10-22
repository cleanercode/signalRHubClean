using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using davidhartmanninfo.FireIncidentRealtime.Models;
using davidhartmanninfo.FireIncidentRealtime.ServiceBus;
using System.Threading.Tasks;

namespace davidhartmanninfo.FireIncidentRealtime.Hubs
{
    /// <summary>
    /// Notify web users immediately in case of new fire incidents
    /// </summary>
    public class FireIncidentHub : Hub<IFireIncidentHubClient>
    {
        /// <summary>
        /// Initialize the hub
        /// </summary>
        /// <param name="notifier">Used to handle fire incidents</param>
        public FireIncidentHub(FireIncidentNotify notifier)
        {
            if (!notifier.IsRegistered)
                notifier.FireIncident += (sender, fireIncident) => { NotifyAllUsers(fireIncident); };
        }

        /// <summary>
        /// notify the web clients
        /// </summary>
        /// <param name="incident">the incident to inform clients about</param>
        public void NotifyAllUsers(FireIncident incident)
        {
            Clients.All.notify(incident);
        }
    }
}