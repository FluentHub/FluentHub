namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UnmarkFileAsViewed
    /// </summary>
    public class UnmarkFileAsViewedInput
    {
        /// <summary>
        /// The Node ID of the pull request.
        /// </summary>
        public ID PullRequestId { get; set; }

        /// <summary>
        /// The path of the file to mark as unviewed
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}