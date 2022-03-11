using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSessionState_Poc.ViewModels
{
    public class OrderECertificateViewModel
    {
        public int OmsOrderECertificateId { get; set; }
        public int ECertificateId { get; set; }
        public int OmsOrderDetailsId { get; set; }
        public decimal AmountUsed { get; set; }
    }
}
