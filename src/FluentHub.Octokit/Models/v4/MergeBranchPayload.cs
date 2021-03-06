namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of MergeBranch
    /// </summary>
    public class MergeBranchPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The resulting merge Commit.
        /// </summary>
        public Commit MergeCommit { get; set; }
    }
}