using System.Collections.Generic;

namespace RedisSessionState_Poc.ViewModels
{
    public class PowerBISettingsViewModel : BaseViewModel
    {
        public string PowerBIApplicationId { get; set; }

        public string PowerBITenantId { get; set; }

        public string PowerBIUserName { get; set; }

        public string PowerBIPassword { get; set; }
        public string CurrentReportName { get; set; }
        public PowerBIEmbedViewModel PowerBIEmbedView { get; set; }

        public List<PowerBIGroupSettingsViewModel> PowerBIGroupConfiguration { get; set; }
    }
}