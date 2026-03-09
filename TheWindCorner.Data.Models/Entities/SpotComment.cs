namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.User;

    using static TheWindCorner.Common.EntityValidationConstants.SpotComment;
    using static TheWindCorner.Common.EntityValidationMessages.SpotComment;


    [Comment("The comment on a spot")]
    public class SpotComment
    {

        [Key]
        [Comment("The identifier of the comment made")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(ContentMaxLength, ErrorMessage = ContentMaxLengthMassage)]
        [Comment("The full text of the comment")]
        public string Content { get; set; } = null!;

        [Required]
        [Comment("The date and time the comment was added or edited")]
        public DateTime CommentedOn { get; set; }

        [Required]
        [Comment("If the comment has been edited")]
        public bool IsEdited { get; set; } = false;

        [Required]
        [Comment("If the comment has been deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("The identifier of the user, who made the comment")]
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [Comment("The user, who made the comment")]
        public virtual ApplicationUser Author { get; set; } = null!;

        [Required]
        [Comment("The identifier of the spot, that was commented")]
        public Guid SpotId { get; set; }

        [ForeignKey(nameof(SpotId))]
        [Comment("The spot, that was commented")]
        public virtual Spot Spot { get; set; } = null!;

    }
}
