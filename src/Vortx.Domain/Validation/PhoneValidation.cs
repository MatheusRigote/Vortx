using FluentValidation;
using Vortx.Domain.Model;

namespace Vortx.Domain.Validation
{
    public sealed class PhoneValidation: AbstractValidator<TelephoneLine>
    {
        public PhoneValidation()
        {
            RuleFor(p => p.Number)
                .NotEmpty()
                .NotNull()
                .WithMessage("The phone numer cannot be empty");

            RuleFor(p => p.DirectDistanceDialing)
                .NotEmpty()
                .NotNull()
                .WithMessage("The DDD cannot be empty");
        }
    }
}
