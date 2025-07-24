namespace TheWindCorner.Data.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Web.Infrastructure.Attributes;

    using static TheWindCorner.Common.EntityValidationConstants.Item;
    using static TheWindCorner.Common.EntityValidationMessages.Item;


    [Comment("Item listed for sale or sought after")]
    public class Item
    {
        [Key]
        [Comment("Item Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("The Category of the Item")]
        public Category Category { get; set; }

        [Required]
        [Comment("The Type of the Item")]
        public ItemType ItemType { get; set; }

        [Required]
        [MaxLength(ItemTitleMaxLength)]
        [Comment("A short descriptive title for the item")]
        public string Title { get; set; } = null!;

        [MaxLength(ItemSizeMaxLength)]
        [Comment("The Size of the Item")]
        public string? Size { get; set; }

        [MaxLength(ItemBrandMaxLength)]
        [Comment("The Brand Name of the Item")]
        public string? Brand { get; set; }

        [Required]
        [RangeUntilCurrentYear(ItemMinYear, ErrorMessage = ItemYearValidationMassage)]
        [Comment("The Year of the Item's production or collection")]
        public int Year { get; set; }

        [Required]
        [MaxLength(ItemDescriptionMaxLength)]
        [Comment("A full description of the item")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("If the Item has been approved for listing")]
        public bool IsApproved { get; set; } = false;

        [Required]
        [Comment("If the Item has been deleted")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("If the Item has been sold")]
        public bool IsSold { get; set; } = false;
    }
}
