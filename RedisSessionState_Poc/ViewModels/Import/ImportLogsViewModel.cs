namespace RedisSessionState_Poc.ViewModels
{
    public class ImportLogsViewModel : BaseViewModel
    {
        public int ImportLogId { get; set; }
        public int ImporProcessLogId { get; set; }
        public int? RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
        public string ErrorDescription { get; set; }
    }
}