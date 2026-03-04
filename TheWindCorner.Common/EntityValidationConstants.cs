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
            public const int UsernameMinLength = 3;
            public const int UsernameMaxLength = 20;

            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;

            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;

            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 64;

            public const int EmailMinLength = 5;
            public const int EmailMaxLength = 320;
        }

    }
}
