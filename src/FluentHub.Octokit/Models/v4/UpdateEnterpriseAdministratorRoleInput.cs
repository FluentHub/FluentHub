namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateEnterpriseAdministratorRole
    /// </summary>
    public class UpdateEnterpriseAdministratorRoleInput
    {        /// <summary>
        /// The ID of the Enterprise which the admin belongs to.
        /// </summary>
        public ID EnterpriseId { get; set; }

        /// <summary>
        /// The login of a administrator whose role is being changed.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// The new role for the Enterprise administrator.
        /// </summary>
        public EnterpriseAdministratorRole Role { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}