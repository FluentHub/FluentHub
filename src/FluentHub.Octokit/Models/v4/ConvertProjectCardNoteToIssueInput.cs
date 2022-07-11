namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of ConvertProjectCardNoteToIssue
    /// </summary>
    public class ConvertProjectCardNoteToIssueInput
    {
        /// <summary>
        /// The ProjectCard ID to convert.
        /// </summary>
        public ID ProjectCardId { get; set; }

        /// <summary>
        /// The ID of the repository to create the issue in.
        /// </summary>
        public ID RepositoryId { get; set; }

        /// <summary>
        /// The title of the newly created issue. Defaults to the card's note text.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The body of the newly created issue.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}