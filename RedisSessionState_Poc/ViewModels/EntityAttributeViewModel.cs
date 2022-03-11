using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class EntityAttributeViewModel : BaseViewModel
    {
        public int EntityValueId { get; set; }
        public string EntityType { get; set; }
        public bool IsSuccess { get; set; }
        public int LocaleId { get; set; }
        public int PortalId { get; set; }

        public List<EntityAttributeDetailsViewModel> Attributes { get; set; }

        public EntityAttributeViewModel()
        {
            Attributes = new List<EntityAttributeDetailsViewModel>();
        }
    }
}
