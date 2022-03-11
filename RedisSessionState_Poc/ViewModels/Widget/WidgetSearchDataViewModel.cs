using System;
using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class WidgetSearchDataViewModel : BaseViewModel
    {
        public List<FacetViewModel> Facets { get; set; }
        public List<Tuple<string, List<KeyValuePair<string, string>>>> FacetFilters { get; set; }
        public List<ProductViewModel> Products { get; set; }
        public string SearchResultCountText { get; set; }
    }
}
