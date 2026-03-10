namespace TheWindCorner.Data.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Entities.Comments;


    [Comment("The comment on an item")]
    public class ItemComment : BaseComment
    {

        [Required]
        [Comment("The identifier of the item, that was commented")]
        public Guid ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        [Comment("The item, that was commented")]
        public virtual Item Item { get; set; } = null!;

    }
}
