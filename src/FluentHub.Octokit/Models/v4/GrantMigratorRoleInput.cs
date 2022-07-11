namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of GrantMigratorRole
    /// </summary>
    public class GrantMigratorRoleInput
    {
        /// <summary>
        /// The ID of the organization that the user/team belongs to.
        /// </summary>
        public ID OrganizationId { get; set; }

        /// <summary>
        /// The user login or Team slug to grant the migrator role.
        /// </summary>
        public string Actor { get; set; }

        /// <summary>
        /// Specifies the type of the actor, can be either USER or TEAM.
        /// </summary>
        public ActorType ActorType { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}