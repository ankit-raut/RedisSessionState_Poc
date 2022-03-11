using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class ConfigurableAttributeViewModel:BaseViewModel
    {
        public List<AttributesViewModel> ConfigurableAttributes { get; set; }
        public List<SwatchImageViewModel> SwatchImages { get; set; }
        public string CombinationErrorMessage { get; set; }
    }
}