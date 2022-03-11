using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    /// <summary>
    /// This is the model for Category Header which is used to show the Main navigation menus
    /// </summary>
    public class CategoryHeaderViewModel : BaseViewModel
    {
        public CategoryHeaderViewModel() 
        {
            SubCategoryItems = new List<CategorySubHeaderViewModel>();
        }

        public string CategoryName { set; get; }
        public int CategoryId { set; get; }
        public string SEOPageName { set; get; }
        public int? DisplayOrder { get; set; }
        public List<CategorySubHeaderViewModel> SubCategoryItems { get; set; }
        public int ProductCount { get; set; }
        public int ActiveProductCount { get; set; }

        public List<AttributesViewModel> Attributes { get; set; }
    }
}