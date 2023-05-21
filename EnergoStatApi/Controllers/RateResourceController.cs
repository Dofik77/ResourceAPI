using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;
using EnergoStatApi.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace EnergoStatApi.Controllers
{
    [Route("api/RateResource")]
    [ApiController]
    public class RateResourceController : ControllerBase
    {
        private IRateGraphService _graphService;

        public RateResourceController(IRateGraphService graphService)
        {
            _graphService = graphService;
        }

        [HttpGet("GetRateGraph")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RateGraphModel))]
        public async Task<ActionResult<List<RateGraphModel>>> GetResourceRateGraph([FromQuery] int resourceTypeNumber)
        {
            var graphData = await _graphService.GetRateGraph(resourceTypeNumber);
            return graphData == null ? NotFound() : graphData;
        } 

        //[HttpPost("PostRateData")]
        //[ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        //public async Task<ActionResult<bool>> PostRateData(ElectricRate electricConsumptionModel)
        //{ 
        //    _electricRepository.Created(electricConsumptionModel);
        //    return true; 
        //}
    }
}
