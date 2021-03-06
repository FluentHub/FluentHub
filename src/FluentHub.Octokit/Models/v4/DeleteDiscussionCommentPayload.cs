namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of DeleteDiscussionComment
    /// </summary>
    public class DeleteDiscussionCommentPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The discussion comment that was just deleted.
        /// </summary>
        public DiscussionComment Comment { get; set; }
    }
}