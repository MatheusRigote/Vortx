using System;
using Vortx.Domain.Core.EntityBase;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Validation;

namespace Vortx.Domain.Model
{
    public class TelephoneLine : Entity
    {
        public Guid CustomerId { get; protected set; }
        public string Number { get; protected set; }
        public string DirectDistanceDialing { get; protected set; }        
        public EAgeRating EPhoneType { get; protected set; }
        public EPlan EPlaType { get; protected set; }

        public TelephoneLine(TelephoneLine phone, Guid customerId)
        {
            CustomerId = customerId;
            Number = phone.Number;
            DirectDistanceDialing = phone.DirectDistanceDialing;
            EPhoneType = phone.EPhoneType;

            Validate(this, new PhoneValidation());
        }

        protected TelephoneLine() { }
    }
}
