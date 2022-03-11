namespace RedisSessionState_Poc.ViewModels
{
    public class TierPriceViewModel : BaseViewModel
    {       
        public decimal? Price { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? MinQuantity { get; set; }
        public decimal? MaxQuantity { get; set; }
    }
}