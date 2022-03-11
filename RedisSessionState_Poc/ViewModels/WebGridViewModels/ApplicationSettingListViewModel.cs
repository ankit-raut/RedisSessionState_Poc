using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class ApplicationSettingListViewModel : BaseViewModel
    {
        public List<ApplicationSettingModel> List { get; set; }

        public ApplicationSettingListViewModel()
        {
            List = new List<ApplicationSettingModel>();
        }
    }
}