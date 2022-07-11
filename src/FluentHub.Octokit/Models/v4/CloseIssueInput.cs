namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CloseIssue
    /// </summary>
    public class CloseIssueInput
    {
        /// <summary>
        /// ID of the issue to be closed.
        /// </summary>
        public ID IssueId { get; set; }

        /// <summary>
        /// The reason the issue is to be closed.
        /// </summary>
        public IssueClosedStateReason? StateReason { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}