using FluentValidation;
using System;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Model;

namespace Vortx.Domain.Validation
{
    public sealed class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name cannot be empty");

            RuleFor(c => c.FullName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name cannot be empty");

            RuleFor(c => c.Document.Cpf)
                .NotEmpty()
                .NotNull()
                .WithMessage("Document CPF cannot be empty")
                .Length(11)
                .WithMessage("The CPF should be 9 digit");

            RuleFor(c => c.Document.RG)
                .NotEmpty()
                .NotNull()
                .WithMessage("Document RG cannot be empty")
                .Length(9)
                .WithMessage("The RG should be 9 digit");

            RuleFor(c => c.Document)
                .NotNull()
                .WithMessage("Document is required");

            RuleFor(c => c.BirthDate)
                .LessThan(DateTime.Now).WithMessage("The date of birth should not be the current date")
                .Must(BeAValidDate).WithMessage("The date is not valid")
                .Must(IsAdult).WithMessage("You must be of legal age");                         
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

        private bool IsAdult(DateTime date)
        {            
            var age = (DateTime.Today).Year - date.Year;
            if (date.Date > (DateTime.Today).AddYears(-age))          
                age--;

            return (age > (int)ERanking.Adult);            
        }
    }
}
