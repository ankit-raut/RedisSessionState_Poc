using System.Collections.Generic;
namespace RedisSessionState_Poc.ViewModels
{
    public class CategoryHeaderListViewModel : BaseViewModel
    {
        public CategoryHeaderListViewModel()
        {
            Categories = new List<CategoryHeaderViewModel>();
        }

        public List<CategoryHeaderViewModel> Categories { set; get; }
        public List<BrandViewModel> BrandList { get; set; }
    }
}