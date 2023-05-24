using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using EnergoStatApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Service
{
    public class PaymentResourceRateService : IPaymentResourceRateService
    {
        public IBaseRepository<PaymentResource> _paymentRepository { get; }

        public PaymentResourceRateService(IBaseRepository<PaymentResource> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void PaymentForAll(DateTime mounthAndDayOfPayment, float ElectroRatePayment, float ColdWaterRatePayment, float WarmWhaterRatePayment)
        {
            var paymentData = new PaymentResource()
            {
                MounthAndDayOfPayment = mounthAndDayOfPayment,
                ElectroRatePayment = ElectroRatePayment,
                ColdWaterRatePayment = ColdWaterRatePayment,
                WarmWhaterRatePayment = WarmWhaterRatePayment
            };

            _paymentRepository.Add(paymentData);
        }
    }
}
