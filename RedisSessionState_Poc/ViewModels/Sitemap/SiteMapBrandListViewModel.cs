using System.Collections.Generic;
using RedisSessionState_Poc;

namespace Znode.WebStore.Core.ViewModels
{
    public class SiteMapBrandListViewModel : BaseViewModel
    {
        public List<SiteMapBrandViewModel> BrandList { get; set; }
    }
}
