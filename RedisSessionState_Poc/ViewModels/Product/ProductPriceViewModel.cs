namespace Redis
{
    public class ProductPriceViewModel
    {
        public string sku { get; set; }
        public string type { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public string DisplaySalesPrice { get; set; }
        public string DisplayRetailPrice { get; set; }
        public string CurrencyCode { get; set; }
    }
}