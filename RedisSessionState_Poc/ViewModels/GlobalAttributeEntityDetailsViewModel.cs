using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class GlobalAttributeEntityDetailsViewModel : BaseViewModel
    {
        public int EntityId { get; set; }
        public string EntityType { get; set; }

        public bool HasChildAccount { get; set; }
        public List<GlobalAttributeGroupViewModel> Groups { get; set; }
        public List<GlobalAttributeValuesViewModel> Attributes { get; set; }

        public GlobalAttributeEntityDetailsViewModel()
        {
            Attributes = new List<GlobalAttributeValuesViewModel>();
        }
    }
}