using FluentValidation;

namespace InventoryManager.Application.DTOs
{
    /// <summary>
    /// The InventoryItemDTO Validator.
    /// </summary>
    public class InventoryItemDTOValidator : AbstractValidator<InventoryItemDTO>
    {
        /// <summary>
        /// The InventoryItemDTO constructor.
        /// </summary>
        public InventoryItemDTOValidator()
        {
            RuleFor(x => x.Id).NotNull().GreaterThanOrEqualTo(0);
            RuleFor(x => x.Name).Length(0, 50).NotNull();
            RuleFor(x => x.ExpirationDate).GreaterThan(new DateTime(1950, 1, 1));
            RuleFor(x => x.Type).InclusiveBetween(0, 10);
        }
    }
}
