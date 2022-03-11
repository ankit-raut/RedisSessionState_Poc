namespace RedisSessionState_Poc.ViewModels
{
    public class InventorySKUViewModel : BaseViewModel
    {
        public string SKU { get; set; }

        public decimal Quantity { get; set; }

        public decimal? ReOrderLevel { get; set; }
        public int InventoryId { get; set; }
        public int? WarehouseId { get; set; }
        public string ListName { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseCode { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string ExternalId { get; set; }

    }
}
