namespace RedisSessionState_Poc.ViewModels
{
    public class PowerBIGroupSettingsViewModel : BaseViewModel
    {
        public string PowerBIGroupId { get; set; }
        public string PowerBIReportId { get; set; }
        public string PowerBIReportTableName { get; set; }
        public string PowerBIReportName { get; set; }
        public string PowerBIPortalFilterId { get; set; }
    }
}