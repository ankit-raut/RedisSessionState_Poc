using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class BlogNewsCommentListViewModel : BaseViewModel
    {
        public List<BlogNewsCommentViewModel> BlogNewsCommentList { set; get; }
    }
}
