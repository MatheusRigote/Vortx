using System.Collections.Generic;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Model;

namespace Vortx.Domain.Contract
{
    public interface IPlan
    {
        IEnumerable<object> GetTheOriginalRegions();
        string GetCallPrice(Plan plan);
        string GetCallPrice(EPlan planCode, EDDD origin, EDDD destiny, int minute);
    }
}
