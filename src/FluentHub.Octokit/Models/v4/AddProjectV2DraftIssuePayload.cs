namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of AddProjectV2DraftIssue
    /// </summary>
    public class AddProjectV2DraftIssuePayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The draft issue added to the project.
        /// </summary>
        public ProjectV2Item ProjectItem { get; set; }
    }
}