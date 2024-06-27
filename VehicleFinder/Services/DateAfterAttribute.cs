using System.ComponentModel.DataAnnotations;

public class DateAfterAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public DateAfterAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var comparisonProperty = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (comparisonProperty == null)
        {
            return new ValidationResult($"Unknown property: {_comparisonProperty}");
        }

        var comparisonValue = comparisonProperty.GetValue(validationContext.ObjectInstance);

        if (value != null && comparisonValue != null && value is DateOnly currentValue && comparisonValue is int comparisonYear)
        {
            var comparisonDate = new DateOnly(comparisonYear, 1, 1);

            if (currentValue <= comparisonDate)
            {
                return new ValidationResult($"The {validationContext.DisplayName} must be after the {comparisonProperty.Name}.");
            }
        }

        return ValidationResult.Success;
    }
}
