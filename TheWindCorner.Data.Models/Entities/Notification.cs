namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Data.Models.User;


    [Comment("Notification to the admin about user's action")]
    public class Notification
    {

        [Key]
        [Comment("The identifier of the notification")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("The date and time the notification was sent")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Comment("The identifier of the entity that triggered the notification")]
        public Guid EntityId { get; set; }

        [Required]
        [Comment("The type of the entity")]
        public NotifiableEntityType EntityType { get; set; }

        [Required]
        [Comment("If the notification has been read by the admin")]
        public bool IsRead { get; set; } = false;

        [Required]
        [Comment("If the notified action has been handled by the admin")]
        public bool IsHandled { get; set; } = false;

        [Required]
        [Comment("The identifier of the user whose action triggered the notification")]
        public Guid TriggeredById { get; set; }

        [ForeignKey(nameof(TriggeredById))]
        [Comment("The user whose action triggered the notification")]
        public virtual ApplicationUser TriggeredBy { get; set; } = null!;

    }
}
