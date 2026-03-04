namespace TheWindCorner.Data.Models.User
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TheWindCorner.Data.Models.Entities;

    using static TheWindCorner.Common.EntityValidationConstants.User;
    using static TheWindCorner.Common.EntityValidationMessages.User;


    public class ApplicationUser
    {
        [Key]
        [Comment("The identifier of the user")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(UsernameMaxLength, ErrorMessage = UsernameMaxLengthMessage)]
        [Comment("The username of the user")]
        public override string? UserName { get; set; }

        [MaxLength(UsernameMaxLength, ErrorMessage = UsernameMaxLengthMessage)]
        [Comment("The first name of the user")]
        public string? FirstName { get; set; }

        [MaxLength(LastNameMaxLength, ErrorMessage = LastNameMaxLengthMessage)]
        [Comment("The last name of the user")]
        public string? LastName { get; set; }

        [Comment("The path or URL of the user's profile image")]
        public string? ProfileImagePath { get; set; }

        [Comment("The Identifier of the home spot of the user")]
        public Guid? HomeSpotId { get; set; }

        [ForeignKey(nameof(HomeSpotId))]
        [Comment("The home spot of the user")]
        public Spot? HomeSpot { get; set; }

        [Required]
        [Comment("The date and time when the user has been created")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Comment("The date and time when the user has been modified")]
        public DateTime? ModifiedOn { get; set; }

        [Required]
        [Comment("If the user has been deleted")]
        public bool IsDeleted { get; set; }

        [Comment("The date and time when the user has been deleted")]
        public DateTime? DeletedOn { get; set; }


        [Comment("All the items the user has listed for sale")]
        public virtual ICollection<Item> ItemsForSale { get; set; } = new HashSet<Item>();

        [Comment("All the items listed, that the user is looking for")]
        public virtual ICollection<WantedItem> WantedItems { get; set; } = new HashSet<WantedItem>();

        [Comment("Spots added by this user")]
        public virtual ICollection<Spot> AddedSpots { get; set; } = new HashSet<Spot>();



    }
}
