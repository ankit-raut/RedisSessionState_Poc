using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class CategoryListViewModel:BaseViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public CategoryListViewModel()
        {
            Categories = new List<CategoryViewModel>();
        }

    }
}