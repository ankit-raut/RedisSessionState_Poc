using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class CartItemGroupListViewModel :BaseViewModel
    {
        public string SKU { get; set; }

        public string GroupId { get; set; }

        public int Sequence { get; set; }
        public List<CartItemViewModel> Children { get; set; }
    }
}
