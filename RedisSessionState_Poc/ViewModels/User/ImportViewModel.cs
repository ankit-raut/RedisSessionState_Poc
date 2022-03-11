using System.ComponentModel.DataAnnotations;
using System.Web;


namespace RedisSessionState_Poc.ViewModels
{
    public class ImportViewModel : BaseViewModel
    {
        [UIHint("FileUploader")]
        public HttpPostedFileBase ImportData { get; set; }

        public ImportProcessLogsListViewModel ImportProcessLogsListViewModel { get; set; }
    }
}
