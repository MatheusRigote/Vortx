using System.Collections.Generic;
using Vortx.Application.ViewModel;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.Application.Contract
{
    public interface IPlanApplication
    {
        IEnumerable<object> GetRegions();
        string GetCallPrice(PlanViewModel planViewModel);
        string GetCallPrice(EPlan planCode, EDDD origin, EDDD destiny, int minute);
    }
}
