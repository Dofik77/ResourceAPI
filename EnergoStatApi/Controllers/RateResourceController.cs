namespace EnergoStatApi.Controllers
{
    using EnergoStatApi.Domain.Entity;
    using EnergoStatApi.Domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/rateResource")]
    [ApiController]
    public class RateResourceController : ControllerBase
    {
        private IRateGraphService _graphService;

        public RateResourceController(IRateGraphService graphService)
        {
            _graphService = graphService;
        }

        [HttpGet("getRateGraph")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RateGraphModel))]
        public async Task<ActionResult<List<RateGraphModel>>> GetResourceRateGraph([FromQuery] int resourceTypeNumber, 
            DateTime dateStartRateResource, DateTime dateEndRateResource)
        {
            var graphData = await _graphService.GetRateGraph(resourceTypeNumber, dateStartRateResource, dateEndRateResource);
            return graphData == null ? NotFound() : graphData;
        } 
    }
}
