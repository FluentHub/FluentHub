namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of DeletePullRequestReviewComment
    /// </summary>
    public class DeletePullRequestReviewCommentInput
    {
        /// <summary>
        /// The ID of the comment to delete.
        /// </summary>
        public ID Id { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}