using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class UrlRedirectViewModel : BaseViewModel
    {
        public int CMSUrlRedirectId { get; set; }
        public int PortalId { get; set; }
        public string RedirectFrom { get; set; }
        public string RedirectTo { get; set; }
        public bool IsActive { get; set; }
    }
}
