using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class BlogNewsListViewModel : BaseViewModel
    {
        public List<BlogNewsViewModel> BlogNewsList { set; get; }

        public string BlogNewsType { get; set; }
    }
}