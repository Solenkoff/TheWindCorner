namespace TheWindCorner.Data.Models.Entities.Comments
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;


    [Comment("The comment on a spot")]
    public class SpotComment : BaseComment
    {

        [Required]
        [Comment("The identifier of the spot, that was commented")]
        public Guid SpotId { get; set; }

        [ForeignKey(nameof(SpotId))]
        [Comment("The spot, that was commented")]
        public virtual Spot Spot { get; set; } = null!;

    }
}
