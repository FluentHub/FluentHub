using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FluentHub.Octokit.v4.Model
{
    /// <summary>
    /// Properties by which enterprise owners can be ordered.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrgEnterpriseOwnerOrderField
    {
        /// <summary>
        /// Order enterprise owners by login.
        /// </summary>
        [EnumMember(Value = "LOGIN")]
        Login,
    }
}