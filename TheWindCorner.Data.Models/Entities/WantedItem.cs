namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Entities.Contracts;
    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Data.Models.User;

    using static TheWindCorner.Common.EntityValidationConstants.WantedItem;

    [Comment("Item that an user is looking for")]
    public class WantedItem : INotifiableEntity
    {

        [Key]
        [Comment("The identifier of the wanted item")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("The entity type used for notification routing")]
        public NotifiableEntityType EntityType => NotifiableEntityType.WantedItem;

        [Required]
        [Comment("The Category of the Item")]
        public Category Category { get; set; }

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

        [Required]
        [Comment("The Identifier of the user who added the listing of the item they are seeking")]
        public Guid CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        [Comment("The user who added the listing of the item they are seeking")]
        public virtual ApplicationUser CreatedBy { get; set; } = null!;

    }
}
