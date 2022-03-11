using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSessionState_Poc.ViewModels
{
    public class ECertTotalBalanceViewModel : BaseViewModel
    {
        public decimal AvailableTotal { get; set; }         

        public string TraceMessage { get; set; }

        public string CurrencyCode { get; set; }

        public string CultureCode { get; set; }

    }
}
