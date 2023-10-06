using FluentValidation;

namespace PetShopAPI.Models.Validation
{
    public class UpdateProductDtoValidation : AbstractValidator<UpdateProductDto>
    {
        public UpdateProductDtoValidation()
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

            RuleFor(p => p.CategoryId)
                .NotEmpty();
        }
    }
}
