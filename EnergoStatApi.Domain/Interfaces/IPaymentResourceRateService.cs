using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Interfaces
{
    public interface IPaymentResourceRateService
    {
        public void PaymentForAll(DateTime mounthAndDayOfPayment, float ElectroRatePayment, float ColdWaterRatePayment, float WarmWhaterRatePayment);
    }
}
