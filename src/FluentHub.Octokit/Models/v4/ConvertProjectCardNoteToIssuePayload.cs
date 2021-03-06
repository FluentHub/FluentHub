namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of ConvertProjectCardNoteToIssue
    /// </summary>
    public class ConvertProjectCardNoteToIssuePayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The updated ProjectCard.
        /// </summary>
        public ProjectCard ProjectCard { get; set; }
    }
}