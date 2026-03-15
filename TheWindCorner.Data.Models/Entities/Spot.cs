namespace TheWindCorner.Data.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using TheWindCorner.Data.Models.Entities.Comments;
    using TheWindCorner.Data.Models.Entities.Contracts;
    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Data.Models.User;

    using static TheWindCorner.Common.EntityValidationConstants.Spot;
    using static TheWindCorner.Common.EntityValidationMessages.Spot;

    [Comment("A location, where one of the wind-sports can be practiced")]
    public class Spot : INotifiableEntity
    {
        [Key]
        [Comment("The identifier of the spot")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [NotMapped]
        [Comment("The entity type used for notification routing")]
        public NotifiableEntityType EntityType => NotifiableEntityType.Spot;

        [Required]
        [MaxLength(NameMaxLength, ErrorMessage = NameMaxLengthMessage)]
        [Comment("The name of the spot")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength, ErrorMessage = DescriptionMaxLengthMessage)]
        [Comment("A full description of the spot")]
        public string Description { get; set; } = null!;

        [Range(-90, 90, ErrorMessage = LatitudeValidationMessage)]
        [Comment("The latitude of the spot's location")]
        public double? Latitude { get; set; }

        [Range(-180, 180, ErrorMessage = LongitudeValidationMessage)]
        [Comment("The longitude of the spot's location")]
        public double? Longitude { get; set; }

        [Required]
        [Comment("The date and time, when the spot was added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Comment("If the spot has been approved for listing")]
        public bool IsApproved { get; set; } = false;

        [Required]
        [Comment("If the spot has been deleted")]
        public bool IsDeleted { get; set; } = false;


        [Required]
        [Comment("The identifier of the user, who added this spot")]
        public Guid CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        [Comment("The user, who added this spot")]
        public virtual ApplicationUser CreatedBy { get; set; } = null!;


        [Comment("All users who have this as their home spot")]
        public virtual ICollection<ApplicationUser> HomeSpotUsers { get; set; } = new HashSet<ApplicationUser>();

        [Comment("All events that take place on this spot")]
        public virtual ICollection<Event> Events { get; set; } = new HashSet<Event>();

        [Comment("All the comments made on the spot")]
        public virtual ICollection<SpotComment> Comments { get; set; } = new HashSet<SpotComment>();

    }
}
