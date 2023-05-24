using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;
using EnergoStatApi.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace EnergoStat.Api.Controllers
{
    public class PaymentResourceRateController : Controller
    {
        public IPaymentResourceRateService _paymentResourceRateService { get; }

        public PaymentResourceRateController(IPaymentResourceRateService paymentResourceRateService)
        {
            _paymentResourceRateService = paymentResourceRateService;
        }

        [HttpPost("PostPayment")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult PostPaymantData([FromQuery] DateTime mounthAndDayOfPayment, float electroRatePayment, float coldWaterRatePayment, float warmWhaterRatePayment)
        {
            _paymentResourceRateService.PaymentForAll(mounthAndDayOfPayment, electroRatePayment, coldWaterRatePayment, warmWhaterRatePayment);
            return Ok();
        }

    }
}
