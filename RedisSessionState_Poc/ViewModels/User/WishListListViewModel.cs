using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class WishListListViewModel : BaseViewModel
    {
        public List<WishListViewModel> WishList { get; set; }
    }
}