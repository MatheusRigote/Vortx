using System;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.Domain.Core.EntityBase
{
    public abstract class Entity : EntityBaseValidator
    {
        public int Id { get; private set; }
        public Guid GuiId { get; protected set; }
        public EStatus EStatus { get; protected set; }        
        public DateTime CreatedDate { get; protected set; }
        public DateTime ChangeDate { get; protected set; }

        public Entity()
        {
            GuiId = Guid.NewGuid();
        }       
    }
}
