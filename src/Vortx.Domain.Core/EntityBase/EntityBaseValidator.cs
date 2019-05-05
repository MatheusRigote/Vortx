using FluentValidation;
using FluentValidation.Results;

namespace Vortx.Domain.Core.EntityBase
{
    public abstract class EntityBaseValidator
    {
        public bool IsValid { get; private set; }
        public ValidationResult ErrorMessages { get; private set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ErrorMessages = validator.Validate(model);
            IsValid = ErrorMessages.IsValid;
            return ErrorMessages.IsValid;
        }
    }
}
