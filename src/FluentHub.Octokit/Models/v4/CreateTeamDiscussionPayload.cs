namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of CreateTeamDiscussion
    /// </summary>
    public class CreateTeamDiscussionPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The new discussion.
        /// </summary>
        public TeamDiscussion TeamDiscussion { get; set; }
    }
}