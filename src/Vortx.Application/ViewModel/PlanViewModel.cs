using System;

namespace Vortx.Application.ViewModel
{
    public class PlanViewModel
    {
        public int PlanCode { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public DateTime Minute { get; set; }
        public decimal PricePerMinute { get; set; }        
    }
}
