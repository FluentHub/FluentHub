namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of CreateSponsorsTier
    /// </summary>
    public class CreateSponsorsTierPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The new tier.
        /// </summary>
        public SponsorsTier SponsorsTier { get; set; }
    }
}