using FluentValidation;

namespace FulentValidation;
public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(u=>u.Name).NotNull().NotEmpty();
        RuleFor(u=> u.Email).NotEmpty().EmailAddress();
        RuleFor(property =>property.Address).NotNull().NotEmpty().MaximumLength(10);
        RuleFor(property => property.Address).Must(x => x?.ToLower().Contains("street") == true)
            .WithMessage("Address must contain street.");
    }
}
