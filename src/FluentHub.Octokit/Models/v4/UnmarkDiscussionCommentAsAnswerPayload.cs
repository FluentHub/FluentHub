namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UnmarkDiscussionCommentAsAnswer
    /// </summary>
    public class UnmarkDiscussionCommentAsAnswerPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The discussion that includes the comment.
        /// </summary>
        public Discussion Discussion { get; set; }
    }
}