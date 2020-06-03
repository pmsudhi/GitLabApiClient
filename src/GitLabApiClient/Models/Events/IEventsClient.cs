using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient.Models.Events.Requests;
using GitLabApiClient.Models.Events.Responses;

namespace GitLabApiClient.Models.Events
{
    public interface IEventsClient
    {
        /// <summary>
        /// Retrieves Events related to Logged In user
        /// </summary>
        /// <returns></returns>
        Task<IList<Event>> GetAsync(Action<EventQueryOptions> options = null);
    }
}
