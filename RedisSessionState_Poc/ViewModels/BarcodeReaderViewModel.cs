namespace RedisSessionState_Poc.ViewModels
{
    public class BarcodeReaderViewModel : BaseViewModel
    {
        public string DomainName { get; set; }
        public string LicenseKey { get; set; }
        public string Message { get; set; }
        public string BarcodeFormates { get; set; }
        public bool EnableSpecificSearch { get; set; } = false;
    }
}
