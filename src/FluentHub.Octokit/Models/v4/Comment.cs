namespace FluentHub.Octokit.v4.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a comment.
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// The actor who authored the comment.
        /// </summary>
        IActor Author { get; set; }

        /// <summary>
        /// Author's association with the subject of the comment.
        /// </summary>
        CommentAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The body as Markdown.
        /// </summary>
        string Body { get; set; }

        /// <summary>
        /// The body rendered to HTML.
        /// </summary>
        string BodyHTML { get; set; }

        /// <summary>
        /// The body rendered to text.
        /// </summary>
        string BodyText { get; set; }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Check if this comment was created via an email reply.
        /// </summary>
        bool CreatedViaEmail { get; set; }

        /// <summary>
        /// The actor who edited the comment.
        /// </summary>
        IActor Editor { get; set; }

        ID Id { get; set; }

        /// <summary>
        /// Check if this comment was edited and includes an edit with the creation data
        /// </summary>
        bool IncludesCreatedEdit { get; set; }

        /// <summary>
        /// The moment the editor made the last edit
        /// </summary>
        DateTimeOffset? LastEditedAt { get; set; }

        /// <summary>
        /// Identifies when the comment was published at.
        /// </summary>
        DateTimeOffset? PublishedAt { get; set; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// A list of edits to this content.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        UserContentEditConnection UserContentEdits { get; set; }

        /// <summary>
        /// Did the viewer author this comment.
        /// </summary>
        bool ViewerDidAuthor { get; set; }
    }
}

namespace FluentHub.Octokit.v4.Model.Internal
{
    using System;
    using System.Collections.Generic;

    internal class StubIComment
    {
        

        public IActor Author { get; set; }

        public CommentAuthorAssociation AuthorAssociation { get; set; }

        public string Body { get; set; }

        public string BodyHTML { get; set; }

        public string BodyText { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public bool CreatedViaEmail { get; set; }

        public IActor Editor { get; set; }

        public ID Id { get; set; }

        public bool IncludesCreatedEdit { get; set; }

        public DateTimeOffset? LastEditedAt { get; set; }

        public DateTimeOffset? PublishedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public UserContentEditConnection UserContentEdits { get; set; }

        public bool ViewerDidAuthor { get; set; }
    }
}