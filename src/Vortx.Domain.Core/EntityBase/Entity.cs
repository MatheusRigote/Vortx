using FluentValidation;
using FluentValidation.Results;
using System;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.Domain.Core.EntityBase
{
    public abstract class Entity
    {
        public int Id { get; private set; }
        public Guid GuiId { get; protected set; }
        public EStatus EStatus { get; protected set; }
        public bool IsValid { get; private set; }
        public ValidationResult ErrorMessages { get; private set; }
        public DateTime CreatedDate { get; protected set; }
        public DateTime ChangeDate { get; protected set; }

        public Entity()
        {
            GuiId = Guid.NewGuid();
        }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ErrorMessages = validator.Validate(model);
            IsValid = ErrorMessages.IsValid;
            return ErrorMessages.IsValid;
        }
    }
}
