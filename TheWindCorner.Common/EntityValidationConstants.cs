namespace TheWindCorner.Common
{
    public static class EntityValidationConstants
    {

        public static class Item
        {
            public const int TitleMaxLength = 80;
            public const int SizeMaxLength = 50;
            public const int BrandMaxLength = 80;
            public const int ModelMaxLength = 80;
            public const int MinYear = 2000;
            public const string PriceMinValue = "1";
            public const string PriceMaxValue = "10000";
            public const int DescriptionMaxLength = 1000;

        }

        public static class WantedItem
        {
            public const int TitleMaxLength = 80;

            public const int DescriptionMaxLength = 1000;
        }


    }
}
