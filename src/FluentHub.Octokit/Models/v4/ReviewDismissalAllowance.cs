namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// A user, team, or app who has the ability to dismiss a review on a protected branch.
    /// </summary>
    public class ReviewDismissalAllowance
    {
        /// <summary>
        /// The actor that can dismiss.
        /// </summary>
        public ReviewDismissalAllowanceActor Actor { get; set; }

        /// <summary>
        /// Identifies the branch protection rule associated with the allowed user, team, or app.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule { get; set; }

        public ID Id { get; set; }
    }
}