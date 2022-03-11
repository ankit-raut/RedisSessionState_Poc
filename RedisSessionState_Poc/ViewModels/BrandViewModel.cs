namespace RedisSessionState_Poc.ViewModels
{
    public class BrandViewModel : BaseViewModel
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }
        public string BrandCode { get; set; }
        public int? MediaId { get; set; }
        public string Description { get; set; }
        public string WebsiteLink { get; set; }
        public string SEOTitle { get; set; }
        public string SEOKeywords { get; set; }
        public string SEODescription { get; set; }
        public string SEOFriendlyPageName { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; } = true;
        public string MediaPath { get; set; } = "";
        public string BreadCrumbHtml { get; set; }
        public string ImageLargePath { get; set; }
        public string ImageMediumPath { get; set; }
        public string ImageThumbNailPath { get; set; }
        public string ImageSmallPath { get; set; }
        public string ImageSmallThumbnailPath { get; set; }

        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }
    }
}