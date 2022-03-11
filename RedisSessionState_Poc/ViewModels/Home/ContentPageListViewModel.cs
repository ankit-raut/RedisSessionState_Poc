using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class ContentPageListViewModel:BaseViewModel
    {
        public List<ContentPageViewModel> ContentPageList { get; set; }
    }
}