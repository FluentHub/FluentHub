namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UpdateTopics
    /// </summary>
    public class UpdateTopicsPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// Names of the provided topics that are not valid.
        /// </summary>
        public List<string> InvalidTopicNames { get; set; }

        /// <summary>
        /// The updated repository.
        /// </summary>
        public Repository Repository { get; set; }
    }
}