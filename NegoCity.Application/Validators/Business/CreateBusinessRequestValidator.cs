using FluentValidation;
using NegoCity.Application.DTOs.Business;

namespace NegoCity.Application.Validators.Business
{
    public class CreateBusinessRequestValidator: AbstractValidator<CreateBusinessRequest>
    {
        public CreateBusinessRequestValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage("Business name is required.")
               .MaximumLength(150)
               .WithMessage("Business name must not exceed 150 characters.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Business description is required.")
                .MaximumLength(250)
                .WithMessage("Business description must not exceed 250 characters.");
        }
    }
}
