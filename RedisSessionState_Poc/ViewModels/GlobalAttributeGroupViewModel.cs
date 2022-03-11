using System.Collections.Generic;
using Znode.Engine.Api.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class GlobalAttributeGroupViewModel : BaseViewModel
    {
        public int GlobalAttributeGroupId { get; set; }
        public string GroupCode { get; set; }
        public string AttributeGroupName { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsNonEditable { get; set; }
        public List<GlobalAttributeModel> Attributes { get; set; }
        public string GroupType { get; set; }
    }
}
