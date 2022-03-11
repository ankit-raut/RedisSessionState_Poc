using System.ComponentModel.DataAnnotations;

namespace RedisSessionState_Poc.ViewModels
{
    public class ProductReviewViewModel : BaseViewModel
    {
        public int? UserId { get; set; }
        public int PublishProductId { get; set; }
        public decimal Rating { get; set; }
        public int CMSCustomerReviewId { get; set; }

        public string Comments { get; set; }


        public string UserName { get; set; }
        
        public string Status { get; set; }

        public string Headline { get; set; }

        public string UserLocation { get; set; }
        
        public string Duration { get; set; }
        
        public string ProductName { get; set; }
        
        public string SEODescription { get; set; }
        
        public string SEOKeywords { get; set; }
        
        public string SEOTitle { get; set; }
        public string SEOUrl { get; set; }

        public int PortalId { get; set; }
        
        public string SKU { get; set; }
    }
}