using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class LinkProductViewModel : BaseViewModel
    {
        public string AttributeName { get; set; }
        public List<ProductViewModel> PublishProduct { get; set; }

        public LinkProductViewModel()
        {
            PublishProduct = new List<ProductViewModel>();
        }
    }
}