namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of MarkDiscussionCommentAsAnswer
    /// </summary>
    public class MarkDiscussionCommentAsAnswerPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The discussion that includes the chosen comment.
        /// </summary>
        public Discussion Discussion { get; set; }
    }
}