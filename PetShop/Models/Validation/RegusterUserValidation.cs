using FluentValidation;
using PetShopAPI.Data;

namespace PetShopAPI.Models.Validation
{
    public class RegisterUserValidation : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserValidation(PetShopDbContext dbContext)
        {
            RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(u => u.Email)
                .Custom((value, context) =>
                {
                    var emailExist = dbContext.Users.Any(u => u.Email == value);
                    if(emailExist)
                    {
                        context.AddFailure("Email", "Email already exist");
                    }
                });

            RuleFor(u => u.FirstName)
                .NotEmpty();

            RuleFor(u => u.LastName)
                .NotEmpty();

            RuleFor(u => u.Password)
                .NotEmpty();

            RuleFor(u => u.ConfirmPassword)
                .Equal(u => u.Password);

        }
    }
}
