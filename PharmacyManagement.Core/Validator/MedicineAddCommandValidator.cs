
namespace PharmacyManagement.Core.Validator
{
    using FluentValidation;
    using Core.Command;
    public class MedicineAddCommandValidator : AbstractValidator<MedicineAddCommand>
    {
        public MedicineAddCommandValidator()
        {
            this.RuleFor(command => command.Name)
                .NotNull()
                .WithMessage("Medicine Name required.")
                .MaximumLength(50)
                .WithMessage("Medicine Name shouldn't be more that 50 characters.");

            this.RuleFor(command => command.Brand)
              .NotNull()
              .WithMessage("Medicine Brand Name required.")
              .MaximumLength(50)
              .WithMessage("Medicine Brand Name shouldn't be more that 50 characters.");

            this.RuleFor(command => command.Price)
              .GreaterThan(0)
              .WithMessage("Medicine Price is not valid");

            

        }
        

    }
}
