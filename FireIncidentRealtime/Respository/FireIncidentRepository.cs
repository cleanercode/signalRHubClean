﻿using davidhartmanninfo.FireIncidentRealtime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davidhartmanninfo.FireIncidentRealtime.Respository
{
    /// <summary>
    /// Repository for FireIncidents, for demo purposes. Holds incidents in memory.
    /// </summary>
    public class FireIncidentRepository
    {
        /// <summary>
        /// In memory storage of fire incidents
        /// </summary>
        public IEnumerable<FireIncident> FireIncidents { get; set; }

        public FireIncidentRepository()
        {
            FireIncidents = new List<FireIncident>();
        }

        /// <summary>
        /// Add a fire incident to repository
        /// </summary>
        /// <param name="incident">the incident to add</param>
        /// <returns></returns>
        public FireIncident Add(FireIncident incident)
        {
            List<FireIncident> fireIncidents = (FireIncidents as List<FireIncident>);

            //this is for demo purposes. 100 elements do the trick
            if (fireIncidents.Count() > 100)
                fireIncidents.RemoveRange(0, 1);

            fireIncidents.Add(incident);

            return incident;
        }
    }
}