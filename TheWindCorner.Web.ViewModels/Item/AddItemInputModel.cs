namespace TheWindCorner.Web.ViewModels.Item
{
    using System.ComponentModel.DataAnnotations;

    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Web.Infrastructure.Attributes;

    using static Common.EntityValidationConstants.Item;
    using static Common.EntityValidationMessages.Item;


    public class AddItemInputModel
    {
        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = ItemCategoryValidationMassage)]
        public Category Category { get; set; }

        [Required]
        [EnumDataType(typeof(ItemType), ErrorMessage = ItemTypeValidationMassage)]
        public ItemType ItemType { get; set; }

        [Required]
        [MinLength(ItemTitleMinLength, ErrorMessage = ItemTitleMinLengthMassage)]
        [MaxLength(ItemTitleMaxLength, ErrorMessage = ItemTitleMaxLengthMassage)]
        public string Title { get; set; } = null!;

        [MinLength(ItemSizeMinLength, ErrorMessage = ItemSizeMinLengthMassage)]
        [MaxLength(ItemSizeMaxLength, ErrorMessage = ItemSizeMaxLengthMassage)]
        public string? Size { get; set; }

        [MinLength(ItemBrandMinLength, ErrorMessage = ItemBrandMinLengthMassage)]
        [MaxLength(ItemBrandMaxLength, ErrorMessage = ItemBrandMaxLengthMassage)]
        public string? Brand { get; set; }

        [Required]
        [RangeUntilCurrentYear(ItemMinYear, ErrorMessage = ItemYearValidationMassage)]
        public int Year { get; set; }

        [Required]
        [MinLength(ItemDescriptionMinLength, ErrorMessage = ItemDescriptionMinLengthMassage)]
        [MaxLength(ItemDescriptionMaxLength, ErrorMessage = ItemDescriptionMaxLengthMassage)]
        public string Description { get; set; } = null!;

    }
}

