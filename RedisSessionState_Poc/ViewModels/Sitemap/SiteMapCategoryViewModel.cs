using System.Collections.Generic;

using RedisSessionState_Poc;

namespace Znode.WebStore.Core.ViewModels
{
    public class SiteMapCategoryViewModel : BaseViewModel
    {
        public string CategoryName { set; get; }
        public int ZnodeCategoryId { set; get; }
        public string SEOUrl { set; get; }
        public List<SiteMapCategoryViewModel> SubCategoryItems { get; set; }
    }
}
