namespace TheWindCorner.Data.Models.Entities
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TheWindCorner.Data.Models.User;

    using static TheWindCorner.Common.EntityValidationConstants.ItemComment;
    using static TheWindCorner.Common.EntityValidationMessages.ItemComment;


    [Comment("The Comment on an item")]
    public class ItemComment
    {

        [Key]
        [Comment("ItemComment Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(ContentMaxLength, ErrorMessage = ContentMaxLengthMassage)]
        [Comment("The full text of the comment")]
        public string Content { get; set; } = null!;

        [Required]
        [Comment("The date and time of the comment")]
        public DateTime CommentedOn { get; set; }


        [Required]
        [ForeignKey(nameof(CommentOwner))]
        [Comment("The identifier of the user, who made the comment")]
        public string UserId { get; set; } = null!;

        [Comment("The user, who made the comment")]
        public virtual ApplicationUser CommentOwner { get; set; } = null!;
         

        [Required]
        [ForeignKey(nameof(CommentedItem))]
        [Comment("The identifier of the item, that was commented")]
        public Guid ItemId { get; set; }

        [Comment("The item, that was commented")]
        public virtual Item CommentedItem { get; set; } = null!;

    }
}
