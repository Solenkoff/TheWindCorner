namespace TheWindCorner.Common
{
    
    public static class EntityValidationMessages
    {

        public static class Item
        {
            public const string ItemYearValidationMassage = "Please enter a valid year, 2000 or later!";
            public const string ItemCategoryValidationMassage = "Invalid item category!";
            public const string ItemTypeValidationMassage = "Invalid item type!";
            public const string ItemTitleMinLengthMassage = "Item Title should be at least 3 characters long!";
            public const string ItemTitleMaxLengthMassage = "Item Title should not be more than 80 characters long!";
            public const string ItemSizeMinLengthMassage = "Item Size should be at least 2 characters long!";
            public const string ItemSizeMaxLengthMassage = "Item Size should not be more than 50 characters long!";
            public const string ItemBrandMinLengthMassage = "Item Brand should be at least 3 characters long!";
            public const string ItemBrandMaxLengthMassage = "Item Brand should not be more than 80 characters long!";
            public const string ItemDescriptionMinLengthMassage = "Item Description should be at least 10 characters long!";
            public const string ItemDescriptionMaxLengthMassage = "Item Description should not be more than 1000 characters long!";
        }

        public static class ItemComment
        {
            public const string ContentMaxLengthMassage = "Item Comment should not be more than 500 characters long!";
        }
    }
}
