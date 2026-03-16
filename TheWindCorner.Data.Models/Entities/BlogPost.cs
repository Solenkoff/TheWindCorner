namespace TheWindCorner.Data.Models.Entities
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TheWindCorner.Data.Models.Entities.Contracts;
    using TheWindCorner.Data.Models.User;
    using static TheWindCorner.Common.EntityValidationConstants.BlogPost;
    using static TheWindCorner.Common.EntityValidationMessages.BlogPost;


    [Comment("A blog-post posted by the admin")]
    public class BlogPost : IDeletableEntity
    {
        [Key]
        [Comment("BlogPost Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(TitleMaxLength, ErrorMessage = TitleMaxLengthMassage)]
        [Comment("A short descriptive title for the blog-post")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ShortTextMaxLength, ErrorMessage = ShortTextMaxLengthMassage)]
        [Comment("A summery of the blog-post")]
        public string ShortText { get; set; } = null!;

        [Required]
        [MaxLength(FullTextMaxLength, ErrorMessage = FullTextMaxLengthMassage)]
        [Comment("The full text of the blog-post")]
        public string FullText { get; set; } = null!;

        [Required]
        [Comment("The date and time when the blog-post was added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Comment("If the blog-post has been deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("The identifier of the admin who created the blog-post")]
        public Guid CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        [Comment("The admin who created the blog-post")]
        public virtual ApplicationUser CreatedBy { get; set; } = null!;

    }
}
