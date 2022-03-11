using RedisSessionState_Poc;

namespace Znode.WebStore.Core.ViewModels
{
    public class ProductHighlightsViewModel : BaseViewModel
    {
        public int HighlightId { get; set; }
        public string HighlightCode { get; set; }
        public string HighlightName { get; set; }
        public string HighlightDescription { get; set; }
        public string HighlightType { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public string Hyperlink { get; set; }
        public string ImageAltTag { get; set; }
        public bool DisplayPopup { get; set; }
        public string HighlightLocation { get; set; }
        public bool IsOnProductListPage { get; set; }
        public bool IsOnProductDetailPage { get; set; }
        public string ClassName { get; set; }
        public string MediaPath { get; set; }
    }
}
