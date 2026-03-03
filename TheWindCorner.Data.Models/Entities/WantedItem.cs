namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;


    using static TheWindCorner.Common.EntityValidationConstants.WantedItem;

    public class WantedItem
    {

        [Key]
        [Comment("The identifier of the wanted item")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("A short descriptive title for the wanted item")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("A full description of the wanted item")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("The date and time, when the sought item was listed")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Comment("If the wanted item has been approved for listing")]
        public bool IsApproved { get; set; } = false;

        [Required]
        [Comment("If the wanted item has been bought")]
        public bool IsFulfilled { get; set; } = false;

        [Required]
        [Comment("If the wanted item has been deleted")]
        public bool IsDeleted { get; set; } = false;


    }
}
