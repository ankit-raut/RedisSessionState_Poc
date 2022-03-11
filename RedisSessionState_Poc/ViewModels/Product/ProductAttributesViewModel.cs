using System.Collections.Generic;
namespace RedisSessionState_Poc.ViewModels
{
    public class ProductAttributesViewModel : BaseViewModel
    {
        public string AttributeValue { get; set; }
        public string ImagePath{ get; set; }
        public bool IsDisabled { get; set; }
        public int DisplayOrder { get; set; }
        public string SwatchText { get; set; }
        public List<AttributesSelectValuesViewModel> SelectValues { get; set; }
    }
}