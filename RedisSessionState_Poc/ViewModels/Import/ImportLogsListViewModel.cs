using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class ImportLogsListViewModel : BaseViewModel
    {
        public ImportLogsListViewModel()
        {
            LogsList = new List<ImportLogsViewModel>();
        }

        public List<ImportLogsViewModel> LogsList { get; set; }
        public GridModel GridModel { get; set; }
    }
}