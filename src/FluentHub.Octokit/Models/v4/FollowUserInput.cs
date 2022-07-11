namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of FollowUser
    /// </summary>
    public class FollowUserInput
    {
        /// <summary>
        /// ID of the user to follow.
        /// </summary>
        public ID UserId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}