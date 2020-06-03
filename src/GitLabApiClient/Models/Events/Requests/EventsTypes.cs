using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GitLabApiClient.Models.Events
{
    public enum ActionTypes
    {
        [EnumMember(Value = " ")]
        All,
        [EnumMember(Value = "created")]
        created,
        [EnumMember(Value = "updated")]
        updated,
        [EnumMember(Value = "closed")]
        closed,
        [EnumMember(Value = "reopened")]
        reopened,
        [EnumMember(Value = "pushed")]
        pushed,
        [EnumMember(Value = "commented")]
        commented,
        [EnumMember(Value = "merged")]
        merged,
        [EnumMember(Value = "joined")]
        joined,
        [EnumMember(Value = "left")]
        left,
        [EnumMember(Value = "destroyed")]
        destroyed,
        [EnumMember(Value = "expired")]
        expired
    }
    public enum TargetTypes
    {
        [EnumMember(Value = " ")]
        All,
        [EnumMember(Value = "issue")]
        issue,
        [EnumMember(Value = "milestone")]
        milestone,
        [EnumMember(Value = "merge_request")]
        merge_request,
        [EnumMember(Value = "note")]
        note,
        [EnumMember(Value = "project")]
        project,
        [EnumMember(Value = "snippet")]
        snippet,
        [EnumMember(Value = "user")]
        user
    }
    public enum SortingOrder
    {
        [EnumMember(Value = " ")]
        None,
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "dsc")]
        Dsc
    }
    /// <summary>
    /// Events can be retrived in 3 diffrent ways.
    /// Default is All events related to logged in user
    /// If you specify user, then events related to the provided userid/username is returned
    /// If you specify Project, then events related to the provided projectid/name is returned
    /// </summary>
    public enum RequestType
    {
        Default,
        User,
        Project
    }
}
