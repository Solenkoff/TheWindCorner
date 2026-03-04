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

    }
}
