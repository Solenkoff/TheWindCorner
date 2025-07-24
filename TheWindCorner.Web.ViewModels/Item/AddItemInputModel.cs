namespace TheWindCorner.Web.ViewModels.Item
{
    using System.ComponentModel.DataAnnotations;

    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Web.Infrastructure.Attributes;

    using static Common.EntityValidationConstants.Item;


    public class AddItemInputModel
    {
        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Invalid category!")]
        public Category Category { get; set; }

        [Required]
        [EnumDataType(typeof(ItemType), ErrorMessage = "Invalid item type!")]
        public ItemType ItemType { get; set; }

        [Required]
        [MinLength(ItemTitleMinLength, ErrorMessage = "Item Title should be at least 3 characters long!")]
        [MaxLength(ItemTitleMaxLength, ErrorMessage = "Item Title should not be more than 80 characters long!")]
        public string Title { get; set; } = null!;

        [MinLength(ItemSizeMinLength, ErrorMessage = "Item Size should be at least 2 characters long!")]
        [MaxLength(ItemSizeMaxLength, ErrorMessage = "Item Size should not be more than 50 characters long!")]
        public string? Size { get; set; }

        [MinLength(ItemBrandMinLength, ErrorMessage = "Item Brand should be at least 3 characters long!")]
        [MaxLength(ItemBrandMaxLength, ErrorMessage = "Item Brand should not be more than 80 characters long!")]
        public string? Brand { get; set; }

        [Required]
        [RangeUntilCurrentYear(ItemMinYear, ErrorMessage = "Please enter a valid year, 2000 or later!")]
        public int Year { get; set; }

        [Required]
        [MinLength(ItemDescriptionMinLength, ErrorMessage = "Item Description should be at least 10 characters long!")]
        [MaxLength(ItemDescriptionMaxLength, ErrorMessage = "Item Description should not be more than 1000 characters long!")]
        public string Description { get; set; } = null!;

    }
}

