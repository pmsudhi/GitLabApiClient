using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Events.Requests;
using GitLabApiClient.Models.Events.Responses;

namespace GitLabApiClient.Models.Events
{
    public sealed class EventsClient : IEventsClient
    {
        private readonly GitLabHttpFacade _httpFacade;
        private readonly EventsQueryBuilder _queryBuilder;

        internal EventsClient(GitLabHttpFacade httpFacade,EventsQueryBuilder eventQuerybuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = eventQuerybuilder;
        }
        public async Task<IList<Event>> GetAsync(Action<EventQueryOptions> options = null)
        {
            var queryOptions = new EventQueryOptions();
            options?.Invoke(queryOptions);
            string eventbaseURl = "";
            switch (queryOptions.RequestType)
            {
                case RequestType.Default:
                    eventbaseURl = "events";
                    break;
                case RequestType.Project:
                    if (queryOptions.Id.IsNullOrEmpty())
                        throw new ArgumentException("Id/Name of project must be specified in EventQueryOptions when calling event for specific project. In case you need events for the logged in user set RequestType to default");
                    eventbaseURl = $"projects/{queryOptions.Id}/events";
                    break;
                case RequestType.User:
                    if (queryOptions.Id.IsNullOrEmpty())
                        throw new ArgumentException("Id/Name of user must be specified in EventQueryOptions when calling event for specific user. In case you need events for the logged in user set RequestType to default");
                    eventbaseURl = $"users/{queryOptions.Id}/events";
                    break;
                default:
                    eventbaseURl = "events";
                    break;
            }
            string url = _queryBuilder.Build(eventbaseURl, queryOptions);
            return await _httpFacade.GetPagedList<Event>(url);
        }
    }
}
