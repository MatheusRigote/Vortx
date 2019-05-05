using System;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.Application.ViewModel
{
    public class PlanViewModel
    {
        public EPlan PlanCode { get; set; }
        public EDDD Origin { get; set; }        
        public EDDD Destiny { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }        
    }
}
