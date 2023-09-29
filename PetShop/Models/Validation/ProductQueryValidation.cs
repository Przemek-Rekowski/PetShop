using FluentValidation;
using PetShopAPI.Entities;
using RestaurantAPI.Models;

namespace PetShopAPI.Models.Validation
{
    public class ProductQueryValidation : AbstractValidator<ProductQuery>
    {
        private int[] allowedPageSizes = new[] { 20, 40, 60 };

        private string[] allowedSortByColumnNames =
            {nameof(Product.Title), nameof(Product.Description), nameof(Product.Price),};
        public ProductQueryValidation()
        {
            RuleFor(r => r.PageNumber).GreaterThanOrEqualTo(1);

            RuleFor(r => r.PageSize).Custom((value, context) =>
            {
                if (!allowedPageSizes.Contains(value))
                {
                    context.AddFailure("PageSize", $"PageSize must in [{string.Join(",", allowedPageSizes)}]");
                }
            });

            RuleFor(r => r.SortBy)
                .Must(value => string.IsNullOrEmpty(value) || allowedSortByColumnNames.Contains(value))
                .WithMessage($"Sort by is optional, or must be in [{string.Join(",", allowedSortByColumnNames)}]");
        }
    }
}
