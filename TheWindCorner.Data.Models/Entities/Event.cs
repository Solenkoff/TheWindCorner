namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using TheWindCorner.Data.Models.Entities.Comments;
    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Data.Models.User;

    using static TheWindCorner.Common.EntityValidationConstants.Event;
    using static TheWindCorner.Common.EntityValidationMessages.Event;


    [Comment("A wind-sports event posted by the admin")]
    public class Event : IValidatableObject
    {
        [Key]
        [Comment("Event Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(TitleMaxLength, ErrorMessage = TitleMaxLengthMassage)]
        [Comment("A short descriptive title for the event")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ShortDescriptionMaxLength, ErrorMessage = ShortDescriptionMaxLengthMassage)]
        [Comment("A short description of the event")]
        public string ShortDescription { get; set; } = null!;

        [Required]
        [MaxLength(FullDescriptionMaxLength, ErrorMessage = FullDescriptionMaxLengthMassage)]
        [Comment("A full description of the event")]
        public string FullDescription { get; set; } = null!;

        [Required]
        [Comment("The date and time, when the event starts")]
        public DateTime Start { get; set; }

        [Required]
        [Comment("The date and time, when the event ends")]
        public DateTime End { get; set; }

        [Required]
        [MaxLength(LocationMaxLength, ErrorMessage = LocationMaxLengthMassage)]
        [Comment("The location, where the event is to be held")]
        public string Location { get; set; } = null!;

        [Required]
        [EnumDataType(typeof(EventStatus))]
        [Comment("The status of the event")]
        public EventStatus Status { get; set; } = EventStatus.Upcoming;

        [Comment("The Identifier of the spot, where the event takes place")]
        public Guid? SpotId { get; set; }

        [ForeignKey(nameof(SpotId))]
        [Comment("The spot, where the event takes place")]
        public Spot? Spot { get; set; }

        [Required]
        [Comment("The date and time when the event was created")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Comment("If the event has been deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("The identifier of the admin who created the event")]
        public Guid CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        [Comment("The admin who created the event")]
        public virtual ApplicationUser CreatedBy { get; set; } = null!;

        [Comment("All the comments made on the event")]
        public virtual ICollection<EventComment> Comments { get; set; } = new HashSet<EventComment>();


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (End <= Start)
            {
                yield return new ValidationResult(
                    EndDateMustBeAfterStartDateMessage,
                    new[] { nameof(End) });
            }
        }
    }
}
