using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Entity
{
    public class PaymentResource
    {
        public DateTime MounthAndDayOfPayment { get; set; }

        public float ElectroRatePayment { get; set; }

        public float ColdWaterRatePayment { get; set; }

        public float WarmWhaterRatePayment { get; set; }
    }
}
