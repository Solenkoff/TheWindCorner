namespace TheWindCorner.Web.Infrastructure.Attributes
{
    using System.ComponentModel.DataAnnotations;


    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class RangeUntilCurrentYearAttribute : ValidationAttribute
    {
        private readonly int minimumYear;

        public RangeUntilCurrentYearAttribute(int minimumYear)
        {
            this.minimumYear = minimumYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is not int year)
            {
                return new ValidationResult("Invalid year value.");
            }

            int currentYear = DateTime.UtcNow.Year;

            if (year < minimumYear || year > currentYear)
            {
                return new ValidationResult(
                    string.Format(
                        ErrorMessage ?? "Year must be between {0} and {1}.",
                        minimumYear,
                        currentYear
                    )
                );
            }

            return ValidationResult.Success;
        }
    }

}
