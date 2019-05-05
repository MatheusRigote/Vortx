using Microsoft.AspNetCore.Mvc;
using Vortx.Application.Contract;
using Vortx.Application.ViewModel;
using Vortx.Domain.Core.Enumerators;

namespace Vortx.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanApplication _planApplication;

        public PlanController(IPlanApplication planApplication)
        {
            _planApplication = planApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_planApplication.GetRegions());
        }

        [HttpPost]
        public IActionResult Post([FromBody]PlanViewModel planViewModel)
        {
            return Ok(_planApplication.GetCallPrice(planViewModel));
        }        

        [HttpGet("{plancode}/{origin}/{destiny}/{minute}")]
        public IActionResult Get([FromQuery]EPlan plan, EDDD origin, EDDD destiny, int minute)
        {
            return Ok(_planApplication.GetCallPrice(plan, origin, destiny, minute));
        }
    }
}
