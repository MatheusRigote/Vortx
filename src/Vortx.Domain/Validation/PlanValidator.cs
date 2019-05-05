using FluentValidation;
using Vortx.Domain.Model;

namespace Vortx.Domain.Validation
{
    public sealed class PlanValidator: AbstractValidator<Plan>
    {
        public PlanValidator()
        {
            RuleFor(x => x.EOrigin)
                .NotEmpty()
                .NotNull()
                .WithMessage("The code ddd origin cannot be empty");                  
            RuleFor(x => x.EDestiny)
                .NotEmpty()
                .NotNull()
                .WithMessage("The code ddd destiny cannot be empty");
            RuleFor(x => x.EPlanCode)                
                .NotNull()
                .WithMessage("Select an plan");
            RuleFor(x => x.StartTime)
                .NotNull()
                .NotEmpty()
                .WithMessage("Capture minute initial");
            RuleFor(x => x.EndTime)
                .NotNull()
                .NotEmpty()
                .WithMessage("Capture minute finished");
        }
    }
}
