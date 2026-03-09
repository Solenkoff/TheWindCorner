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

        public static class Image
        {
            public const int PathMaxLength = 2048;
        }

        public static class User
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
        }

        public static class Spot
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 100;

            public const int DescriptionMinLength = 3;
            public const int DescriptionMaxLength = 1000;

            public const double MinLatitude = -90;
            public const double MaxLatitude = 90;

            public const double MinLongitude = -180;
            public const double MaxLongitude = 180;
        }

        public static class Event
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 70;

            public const int ShortDescriptionMinLength = 10;
            public const int ShortDescriptionMaxLength = 800;

            public const int FullDescriptionMinLength = 10;
            public const int FullDescriptionMaxLength = 10000;

            public const int LocationMinLength = 2;
            public const int LocationMaxLength = 200;
        }

        public static class BlogPost
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 70;

            public const int ShortTextMinLength = 10;
            public const int ShortTextMaxLength = 800;

            public const int FullTextMinLength = 10;
            public const int FullTextMaxLength = 20000;

        }

        public static class ItemComment
        {
            public const int ContentMinLength = 2;
            public const int ContentMaxLength = 500;
        }

        public static class WantedItemComment
        {
            public const int ContentMinLength = 2;
            public const int ContentMaxLength = 500;
        }

    }
}
