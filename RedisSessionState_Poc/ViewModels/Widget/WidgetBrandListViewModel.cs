using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class WidgetBrandListViewModel : BaseViewModel
    {
        public List<WidgetBrandViewModel> Brands { set; get; }
    }
}