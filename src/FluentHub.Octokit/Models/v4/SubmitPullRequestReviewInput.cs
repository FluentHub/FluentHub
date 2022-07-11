namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of SubmitPullRequestReview
    /// </summary>
    public class SubmitPullRequestReviewInput
    {
        /// <summary>
        /// The Pull Request ID to submit any pending reviews.
        /// </summary>
        public ID? PullRequestId { get; set; }

        /// <summary>
        /// The Pull Request Review ID to submit.
        /// </summary>
        public ID? PullRequestReviewId { get; set; }

        /// <summary>
        /// The event to send to the Pull Request Review.
        /// </summary>
        public PullRequestReviewEvent Event { get; set; }

        /// <summary>
        /// The text field to set on the Pull Request Review.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}