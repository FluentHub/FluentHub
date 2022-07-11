namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateSponsorship
    /// </summary>
    public class CreateSponsorshipInput
    {
        /// <summary>
        /// The ID of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorLogin is not given.
        /// </summary>
        public ID? SponsorId { get; set; }

        /// <summary>
        /// The username of the user or organization who is acting as the sponsor, paying for the sponsorship. Required if sponsorId is not given.
        /// </summary>
        public string SponsorLogin { get; set; }

        /// <summary>
        /// The ID of the user or organization who is receiving the sponsorship. Required if sponsorableLogin is not given.
        /// </summary>
        public ID? SponsorableId { get; set; }

        /// <summary>
        /// The username of the user or organization who is receiving the sponsorship. Required if sponsorableId is not given.
        /// </summary>
        public string SponsorableLogin { get; set; }

        /// <summary>
        /// The ID of one of sponsorable's existing tiers to sponsor at. Required if amount is not specified.
        /// </summary>
        public ID? TierId { get; set; }

        /// <summary>
        /// The amount to pay to the sponsorable in US dollars. Required if a tierId is not specified. Valid values: 1-12000.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// Whether the sponsorship should happen monthly/yearly or just this one time. Required if a tierId is not specified.
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Whether the sponsor should receive email updates from the sponsorable.
        /// </summary>
        public bool? ReceiveEmails { get; set; }

        /// <summary>
        /// Specify whether others should be able to see that the sponsor is sponsoring the sponsorable. Public visibility still does not reveal which tier is used.
        /// </summary>
        public SponsorshipPrivacy? PrivacyLevel { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}