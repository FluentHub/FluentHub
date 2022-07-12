namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents a 'transferred' event on a given issue or pull request.
    /// </summary>
    public class TransferredEvent
    {
        /// <summary>
        /// Identifies the actor who performed the event.
        /// </summary>
        public IActor Actor { get; set; }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The repository this came from
        /// </summary>
        public Repository FromRepository { get; set; }

        public ID Id { get; set; }

        /// <summary>
        /// Identifies the issue associated with the event.
        /// </summary>
        public Issue Issue { get; set; }
    }
}