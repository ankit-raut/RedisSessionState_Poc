using System.ComponentModel.DataAnnotations;

namespace RedisSessionState_Poc.ViewModels
{
    public class EmailAFriendViewModel:BaseViewModel
    {
        public string YourMailId { get; set; }
        public string FriendMailId { get; set; }

        public string ProductUrl { get; set; }
        public string ProductName { get; set; }
        public int LocaleId { get; set; }
        public int CatalogId { get; set; }
        public int PortalId { get; set; }

    }
}