using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class UserApproverListViewModel : BaseViewModel
    {
        public List<UserApproverViewModel> UserApprover { get; set; }
        public string CurrencyCode { get; set; }
        public string CultureCode { get; set; }
    }
}
