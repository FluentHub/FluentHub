namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of VerifyVerifiableDomain
    /// </summary>
    public class VerifyVerifiableDomainPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The verifiable domain that was verified.
        /// </summary>
        public VerifiableDomain Domain { get; set; }
    }
}