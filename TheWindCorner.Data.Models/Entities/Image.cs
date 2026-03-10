namespace TheWindCorner.Data.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Enums;

    using static Common.EntityValidationConstants.Image;
   

    [Comment("Image associated with a listed entity")]
    public class Image
    {
        [Key]
        [Comment("Image Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(PathMaxLength)]
        [Comment("The path or URL of the image")]
        public string Path { get; set; } = null!;

        [Required]
        [Comment("The type of entity this image belongs to")]
        public ImageEntityType EntityType { get; set; }

        [Required]
        [Comment("The identifier of the entity this image belongs to")]
        public Guid EntityId { get; set; }

        [Required]
        [Comment("The display order of the image, 0 being the main image")]
        public int DisplayOrder { get; set; } = 0;
    }
}
