namespace TheWindCorner.Data.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Web.Infrastructure.Attributes;
    using TheWindCorner.Data.Models.Enums;

    using static TheWindCorner.Common.EntityValidationConstants.Item;
    using static TheWindCorner.Common.EntityValidationMessages.Item;

    public class Item
    {
        [Key]
        [Comment("Item Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("The Category of the Item")]
        public Category Category { get; set; }

        [Required]
        [Comment("The Type of the Item")]
        public ItemType ItemType { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("A short descriptive title for the item")]
        public string Title { get; set; } = null!;

        [MaxLength(SizeMaxLength)]
        [Comment("The Size of the Item")]
        public string? Size { get; set; }

        [MaxLength(BrandMaxLength)]
        [Comment("The Brand Name of the Item")]
        public string? Brand { get; set; }

        [MaxLength(ModelMaxLength)]
        [Comment("The Model Name of the Item")]
        public string? Model { get; set; }


        [RangeUntilCurrentYear(MinYear, ErrorMessage = YearValidationMassage)]
        [Comment("The Year of the Item's production or collection")]
        public int Year { get; set; }

        [Required]
        [Precision(18, 2)]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        [Comment("The Price of the Item")]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("A full description of the item")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("The date and time, when the item was listed for sale")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Comment("If the Item has been approved for listing")]
        public bool IsApproved { get; set; } = false;

        [Required]
        [Comment("If the Item has been sold")]
        public bool IsSold { get; set; } = false;

        [Required]
        [Comment("If the Item has been deleted")]
        public bool IsDeleted { get; set; } = false;

       
    }
}
