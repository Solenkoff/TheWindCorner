namespace TheWindCorner.Common
{

    public static class EntityValidationMessages
    {
        public static class Item
        {
            public const string YearValidationMassage = "Please enter a valid year, 2000 or later!";
        }

        public static class User
        {
            public const string FirstNameMinLengthMessage = "Item Title should be at least 2 characters long!";
            public const string FirstNameMaxLengthMessage = "Wanted item comment should not be more than 50 characters long!";

            public const string LastNameMinLengthMessage = "Item Title should be at least 2 characters long!";
            public const string LastNameMaxLengthMessage = "Wanted item comment should not be more than 50 characters long!";
        }

        public static class Spot
        {
            public const string NameMinLengthMessage = "Name should be at least 3 characters long!";
            public const string NameMaxLengthMessage = "Name should not be more than 100 characters long!";

            public const string DescriptionMinLengthMessage = "Description should be at least 3 characters long!";
            public const string DescriptionMaxLengthMessage = "Description should not be more than 1000 characters long!";

            public const string LatitudeValidationMessage = "Latitude must be between -90 and 90 degrees.";
            public const string LongitudeValidationMessage = "Longitude must be between -180 and 180 degrees.";
        }

        public static class Event
        {
            public const string TitleMinLengthMassage = "Title should be at least 2 characters long!";
            public const string TitleMaxLengthMassage = "Title should not be more than 50 characters long!";

            public const string ShortDescriptionMinLengthMassage = "Description should be at least 10 characters long!";
            public const string ShortDescriptionMaxLengthMassage = "Description should not be more than 500 characters long!";

            public const string FullDescriptionMinLengthMassage = "FullInfo should be at least 10 characters long!";
            public const string FullDescriptionMaxLengthMassage = "FullInfo should not be more than 2000 characters long!";

            public const string LocationMinLengthMassage = "Location should be at least 2 characters long!";
            public const string LocationMaxLengthMassage = "Location should not be more than 100 characters long!";

        public static class BlogPost
        {
            public const string TitleMinLengthMassage = "Title should be at least 2 characters long!";
            public const string TitleMaxLengthMassage = "Title should not be more than 70 characters long!";

            public const string ShortTextMinLengthMassage = "ShortText should be at least 10 characters long!";
            public const string ShortTextMaxLengthMassage = "ShortText should not be more than 800 characters long!";

            public const string FullTextMinLengthMassage = "FullText should be at least 10 characters long!";
            public const string FullTextMaxLengthMassage = "FullText should not be more than 20000 characters long!";

        }

    }
}
