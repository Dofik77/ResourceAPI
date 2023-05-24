using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnergoStat.Api.Controllers
{
    public class RatePredictedController : Controller
    {
        readonly IRatePerdictedService _ratePerdictedService;

        public RatePredictedController(IRatePerdictedService ratePerdictedService)
        {
            _ratePerdictedService = ratePerdictedService;
        }

        [HttpGet("getPredictModel")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PredictedRateModel> PostPaymentData([FromQuery] int resourceTypeNumber, DateTime currenyMounthToCalculate)
        {
            var predictData = _ratePerdictedService.PredictedRate(resourceTypeNumber, currenyMounthToCalculate);
            return predictData == null ? NotFound() : predictData;
        }
    }
}
