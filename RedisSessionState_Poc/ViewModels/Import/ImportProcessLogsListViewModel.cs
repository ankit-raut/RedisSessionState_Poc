using System.Collections.Generic;
using RedisSessionState_Poc.Models;

namespace RedisSessionState_Poc.ViewModels
{
    public class ImportProcessLogsListViewModel : BaseViewModel
    {
        public ImportProcessLogsListViewModel()
        {
            ProcessLogs = new List<ImportProcessLogsViewModel>();
        }

        public List<ImportProcessLogsViewModel> ProcessLogs { get; set; }

        public GridModel GridModel { get; set; }
    }
}