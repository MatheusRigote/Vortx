using AutoMapper;
using System.Collections.Generic;
using Vortx.Application.Contract;
using Vortx.Application.ViewModel;
using Vortx.Domain.Contract;
using Vortx.Domain.Core.Enumerators;
using Vortx.Domain.Model;

namespace Vortx.Application.Services
{
    public class PlanServiceApplication: IPlanApplication
    {
        private readonly IPlan _plan;
        private readonly IMapper _mapper;

        public PlanServiceApplication(IPlan plan, IMapper mapper)
        {
            _plan = plan;
            _mapper = mapper;
        }

        public IEnumerable<object> GetRegions()
        {
            return _plan.GetTheOriginalRegions();
        }

        public string GetCallPrice(PlanViewModel planViewModel)
        {            
            return _plan.GetCallPrice(_mapper.Map<Plan>(planViewModel));
        }

        public string GetCallPrice(EPlan planCode, EDDD origin, EDDD destiny, int minute)
        {
            return _plan.GetCallPrice(planCode, origin, destiny, minute);
        }
    }
}