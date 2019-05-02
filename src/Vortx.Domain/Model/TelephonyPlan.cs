using System;
using System.Collections.Generic;
using System.Text;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.Domain.Model
{
    public class TelephonyPlan 
    {
        public EPlan EPlan { get; protected set; }
        public string Origin { get; protected set; }
        public string Destiny { get; protected set; }
        public DateTime Minute { get; protected set; }
        public decimal PricePerMinute { get; protected set; }

    }
}
