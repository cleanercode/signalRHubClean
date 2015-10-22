using davidhartmanninfo.FireIncidentRealtime.Hubs;
using davidhartmanninfo.FireIncidentRealtime.Models;
using davidhartmanninfo.FireIncidentRealtime.ServiceBus;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace davidhartmanninfo.FireIncidentRealtime.Controllers
{
    /// <summary>
    /// Responsible for creating fire incidents (post)
    /// </summary>
    public class FireIncidentsController : ApiController
    {
        public FireIncidentNotify Notifier {get; set;}

        /// <summary>
        /// Initialize the controller
        /// </summary>
        /// <param name="notifier">To invoke when fire incidents are created</param>
        public FireIncidentsController(FireIncidentNotify notifier)
        {
            Notifier = notifier;
        }
        /// <summary>
        /// Responsible for creating a fire incident
        /// </summary>
        /// <param name="fireIncident">The fire incident</param>
        /// <returns>Html Status</returns>
        public IHttpActionResult Post(FireIncident fireIncident)
        {
            if (Notifier != null)
                Notifier.Raise(fireIncident);

            return Ok();
        }
    }
}
