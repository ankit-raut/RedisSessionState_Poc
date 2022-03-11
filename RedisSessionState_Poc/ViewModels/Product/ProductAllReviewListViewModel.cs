using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class ProductAllReviewListViewModel : BaseViewModel
    {
        public List<ProductReviewViewModel> AllReviewsList { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
