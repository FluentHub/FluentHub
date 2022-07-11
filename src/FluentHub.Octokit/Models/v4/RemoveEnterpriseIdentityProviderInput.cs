namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RemoveEnterpriseIdentityProvider
    /// </summary>
    public class RemoveEnterpriseIdentityProviderInput
    {
        /// <summary>
        /// The ID of the enterprise from which to remove the identity provider.
        /// </summary>
        public ID EnterpriseId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}