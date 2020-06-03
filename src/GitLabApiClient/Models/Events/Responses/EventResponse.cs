using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Events.Responses
{
    public class Event
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("action_name")]
        public string ActionName { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("target_title")]
        public string TargetTitle { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("author_username")]
        public string Author_Username { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        

    }
}
