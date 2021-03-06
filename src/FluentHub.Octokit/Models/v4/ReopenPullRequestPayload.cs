namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of ReopenPullRequest
    /// </summary>
    public class ReopenPullRequestPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The pull request that was reopened.
        /// </summary>
        public PullRequest PullRequest { get; set; }
    }
}