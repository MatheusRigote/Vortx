using System;
using System.Collections.Generic;
using System.Text;
using Vortx.Domain.Core.EntityBase;
using Vortx.Domain.Core.ValueObject;
using Vortx.Domain.Validation;

namespace Vortx.Domain.Model
{
    public class Customer : Entity
    {
        public string Name { get; protected set; }
        public string FullName { get; protected set; }
        public Document Document { get; protected set; }
        public TelephoneLine Phone { get; protected set; }
        public DateTime BirthDate { get; protected set; }

        protected Customer() { }

        public Customer(Customer customer)
        {
            Name = customer.Name;
            FullName = customer.FullName;
            Document = customer.Document;
            Phone = customer.Phone;
            BirthDate = customer.BirthDate;
            Phone = new TelephoneLine(this.Phone, GuiId);

            Validate(this, new CustomerValidation());
        }
    }
}
