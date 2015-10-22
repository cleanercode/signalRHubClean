using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davidhartmanninfo.FireIncidentRealtime.Models
{
    /// <summary>
    /// A fire broke out. Contains information of where and when this happened
    /// </summary>
    public class FireIncident
    {
        //camelCasing for signalR, see http://blogs.msdn.com/b/stuartleeks/archive/2012/09/10/automatic-camel-casing-of-properties-with-signalr-hubs.aspx
        /// <summary>
        /// Location of the fire incident
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }
        /// <summary>
        /// When did the fire break out?
        /// </summary>
        [JsonProperty("start")]
        public DateTime Start { get; set; }
    }
}