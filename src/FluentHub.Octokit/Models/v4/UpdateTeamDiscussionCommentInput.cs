namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateTeamDiscussionComment
    /// </summary>
    public class UpdateTeamDiscussionCommentInput
    {        /// <summary>
        /// The ID of the comment to modify.
        /// </summary>
        public ID Id { get; set; }

        /// <summary>
        /// The updated text of the comment.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The current version of the body content.
        /// </summary>
        public string BodyVersion { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}