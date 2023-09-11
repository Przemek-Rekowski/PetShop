using FluentValidation;

namespace PetShopAPI.Models.Validation
{
    public class CreateProductDtoValidation : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidation()
        {
            RuleFor(p => p.Title)
                .NotEmpty();

            RuleFor(p => p.Description)
                .NotEmpty();

            RuleFor(p => p.Price)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(p => p.Quantity)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
