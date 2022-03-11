using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class AccountQuoteLineItemListViewModel : BaseViewModel
    {
        public string GroupId { get; set; }
        public List<AccountQuoteLineItemViewModel> AccountQuoteLineItems { get; set; }
    }
}