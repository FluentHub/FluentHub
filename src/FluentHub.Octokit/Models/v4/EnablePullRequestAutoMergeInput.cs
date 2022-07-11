namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of EnablePullRequestAutoMerge
    /// </summary>
    public class EnablePullRequestAutoMergeInput
    {
        /// <summary>
        /// ID of the pull request to enable auto-merge on.
        /// </summary>
        public ID PullRequestId { get; set; }

        /// <summary>
        /// Commit headline to use for the commit when the PR is mergable; if omitted, a default message will be used.
        /// </summary>
        public string CommitHeadline { get; set; }

        /// <summary>
        /// Commit body to use for the commit when the PR is mergable; if omitted, a default message will be used.
        /// </summary>
        public string CommitBody { get; set; }

        /// <summary>
        /// The merge method to use. If omitted, defaults to 'MERGE'
        /// </summary>
        public PullRequestMergeMethod? MergeMethod { get; set; }

        /// <summary>
        /// The email address to associate with this merge.
        /// </summary>
        public string AuthorEmail { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}