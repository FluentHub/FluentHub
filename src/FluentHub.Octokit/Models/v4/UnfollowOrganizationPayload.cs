namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UnfollowOrganization
    /// </summary>
    public class UnfollowOrganizationPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The organization that was unfollowed.
        /// </summary>
        public Organization Organization { get; set; }
    }
}