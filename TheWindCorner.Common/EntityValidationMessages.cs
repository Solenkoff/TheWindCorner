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
            public const string UsernameMinLengthMessage = "Item Title should be at least 3 characters long!";
            public const string UsernameMaxLengthMessage = "Wanted item comment should not be more than 500 characters long!";

            public const string FirstNameMinLengthMessage = "Item Title should be at least 2 characters long!";
            public const string FirstNameMaxLengthMessage = "Wanted item comment should not be more than 50 characters long!";

            public const string LastNameMinLengthMessage = "Item Title should be at least 2 characters long!";
            public const string LastNameMaxLengthMessage = "Wanted item comment should not be more than 50 characters long!";

            public const string PhoneNumberMinLengthMessage = "Phone number should be at least 7 characters long!";
            public const string PhoneNumberMaxLengthMessage = "Phone number should not be more than 15 characters long!";

            public const string PasswordMinLengthMessage = "Password should be at least 6 characters long!";
            public const string PasswordMaxLengthMessage = "Password should not be more than 64 characters long!";

            public const string EmailMinLengthMessage = "Email should be at least 5 characters long!";
            public const string EmailMaxLengthMessage = "Email should not be more than 320 characters long!";
        }

    }
}
