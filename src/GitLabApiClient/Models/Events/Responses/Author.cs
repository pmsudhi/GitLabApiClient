using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Events.Responses
{
    public sealed class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

    }
}
