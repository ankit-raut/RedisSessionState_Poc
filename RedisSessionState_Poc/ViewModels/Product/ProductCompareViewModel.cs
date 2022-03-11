using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class ProductCompareViewModel : BaseViewModel
    {
        public string SenderEmailAddress { get; set; }

        public string RecieverEmailAddress { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int PortalId { get; set; }
        public string ProductIds { get; set; }
        public string BaseUrl { get; set; }
        public string ProductName { get; set; }
        public bool IsProductDetails { get; set; }
        public int LocaleId { get; set; }
        public int CatalogId { get; set; }
        public List<ProductViewModel> ProductList { get; set; }
        public string WebstoreDomainName { get; set; }
        public string WebstoreDomainScheme { get; set; }        
    }
}