using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class PromotionListViewModel : BaseViewModel
    {
        public List<PromotionViewModel> PromotionList { get; set; }
    }
}