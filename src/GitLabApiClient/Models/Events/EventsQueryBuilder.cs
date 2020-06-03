using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Events.Requests;

namespace GitLabApiClient.Models.Events
{
    internal sealed class EventsQueryBuilder : QueryBuilder<EventQueryOptions>
    {
        protected override void BuildCore(Query query, EventQueryOptions options)
        {
            if (options.Action.ToString().IsNotNullOrEmpty() && options.Action.ToString()!="All")
                query.Add("action", options.Action.ToString());
            if (options.Target_Type.ToString().IsNotNullOrEmpty() && options.Target_Type.ToString() != "All")
                query.Add("target_type", options.Target_Type.ToString());
            if (options.Before != default)
                query.Add("before", options.Before.ToUniversalTime().ToString("o")); //Format: ISO 8601 YYYY-MM-DDTHH:MM:SSZ
            if(options.After !=default)
                query.Add("after", options.Before.ToUniversalTime().ToString("o")); //Format: ISO 8601 YYYY-MM-DDTHH:MM:SSZ
            if (options.Sort.ToString().IsNotNullOrEmpty() && options.Sort.ToString() != "None")
                query.Add("sort", options.Sort.ToString());
           
        }
    }
}
