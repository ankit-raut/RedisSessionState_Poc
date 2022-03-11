using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class OrderLineItemGroupedList
    {
        public string GroupId { get; set; }

        public List<OrderLineItemViewModel> Children { get; set; }
    }
}
