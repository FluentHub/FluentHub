namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CloneTemplateRepository
    /// </summary>
    public class CloneTemplateRepositoryInput
    {
        /// <summary>
        /// The Node ID of the template repository.
        /// </summary>
        public ID RepositoryId { get; set; }

        /// <summary>
        /// The name of the new repository.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ID of the owner for the new repository.
        /// </summary>
        public ID OwnerId { get; set; }

        /// <summary>
        /// A short description of the new repository.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates the repository's visibility level.
        /// </summary>
        public RepositoryVisibility Visibility { get; set; }

        /// <summary>
        /// Whether to copy all branches from the template to the new repository. Defaults to copying only the default branch of the template.
        /// </summary>
        public bool? IncludeAllBranches { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}