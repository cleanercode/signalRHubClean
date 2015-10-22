using davidhartmanninfo.FireIncidentRealtime.Models;
using System;
namespace davidhartmanninfo.FireIncidentRealtime.Hubs
{
    /// <summary>
    /// The client proxy for the fire incident hub
    /// </summary>
    public interface IFireIncidentHubClient
    {
        /// <summary>
        /// show fire incident to client
        /// </summary>
        /// <param name="incident">the created fire incident</param>
        void notify(FireIncident incident);
    }
}
