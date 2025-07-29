namespace TheWindCorner.Data.Models.Entities
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    using static TheWindCorner.Common.EntityValidationConstants.Image;

    public class Image
    {

        [Key]
        [Comment("Image Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(TitleMaxLength)]
        [Comment("A short descriptive title for the image")]
        public string? Title { get; set; }

        [MaxLength(TextMaxLength)]
        [Comment("Text added to the image")]
        public string? Text { get; set; }

        [Required]
        [Comment("The path to the image")]
        public string Path { get; set; } = null!;

    }
}
