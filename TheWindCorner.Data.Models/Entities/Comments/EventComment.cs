namespace TheWindCorner.Data.Models.Entities.Comments
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;


    [Comment("The comment on an event")]
    public class EventComment : BaseComment
    {

        [Required]
        [Comment("The identifier of the event, that was commented")]
        public Guid EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        [Comment("The event, that was commented")]
        public virtual Event Event { get; set; } = null!;

    }
}
