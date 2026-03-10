namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Entities.Comments;


    [Comment("The comment on a wanted item")]
    public class WantedItemComment : BaseComment
    {

        [Required]
        [Comment("The identifier of the wanted item, that was commented")]
        public Guid WantedItemId { get; set; }

        [ForeignKey(nameof(WantedItemId))]
        [Comment("The wanted item, that was commented")]
        public virtual WantedItem WantedItem { get; set; } = null!;

    }
}
