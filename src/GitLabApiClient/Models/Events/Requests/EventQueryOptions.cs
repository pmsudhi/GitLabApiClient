using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Internal.Http.Serialization;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Events.Requests
{
    public sealed class EventQueryOptions
    {
        /// <summary>
        /// The ID or Username of the user or project
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Include only events of a particular action type
        /// </summary>
        //        [JsonConverter(typeof(CollectionToCommaSeparatedValuesConverter))]
        //      public List<ActionTypes> Action { get; set; } = new List<ActionTypes>();
        public ActionTypes Action { get; set; } 
        /// <summary>
        /// Include only events of a particular target type
        /// </summary>
       // [JsonConverter(typeof(CollectionToCommaSeparatedValuesConverter))]
        //public List<TargetTypes> Target_Type { get; set; } = new List<TargetTypes>();
        public TargetTypes Target_Type { get; set; }
        /// <summary>
        /// Include only events created before a particular date
        /// </summary>
        public DateTime Before { get; set; }

        /// <summary>
        /// Include only events created after a particular date
        /// </summary>
        public DateTime After { get; set; }

        /// <summary>
        /// ort events in asc or desc order by created_at. Default is desc
        /// </summary>
        public SortOrder Sort { get; set; }

        /// <summary>
        /// Events can be retrived in 3 diffrent ways.
        /// Default is All events related to logged in user
        /// If you specify user, then events related to the provided userid/username is returned
        /// If you specify Project, then events related to the provided projectid/name is returned
        /// </summary>
        public RequestType RequestType { get; set; }
    }
}
