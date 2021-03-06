namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The new edge of the moved column.
        /// </summary>
        public ProjectColumnEdge ColumnEdge { get; set; }
    }
}