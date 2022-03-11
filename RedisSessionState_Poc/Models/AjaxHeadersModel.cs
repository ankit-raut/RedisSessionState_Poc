//using System;
//using System.Configuration;
//using System.Linq;
//using System.Web;
//using RedisSessionState_Poc.ViewModels;
//using System.Text;
//namespace RedisSessionState_Poc
//{
//    public class AjaxHeadersModel
//    {
//        public string Authorization
//        {
//            get
//            {
//                return GetAuthorizationHeader();
//            }
//            set { }
//        }

//        public int ZnodeAccountId { get; set; } = SessionHelper.GetDataFromSession<int>(WebStoreConstants.UserAccountIdKey);

//        public string DomainName { get; set; } = HttpContext.Current.Request.Url.Authority.Trim();

//        public string ApiUrl { get; set; } = ZnodeWebstoreSettings.ZnodeApiRootUri;
//        public string Token { get; set; }

//        private string EncodeBase64(string value) => Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

//        private string GetAuthorizationHeader()
//        {
//            string _token = ZnodeWebstoreSettings.IsGlobalAPIAuthorization
//                ? $"Authorization: Basic {EncodeBase64($"{ZnodeWebstoreSettings.ZnodePaymentApiDomainName}|{ZnodeWebstoreSettings.ZnodePaymentApiDomainKey}")}"
//                : $"Basic {DomainName}|{ConfigurationManager.AppSettings[DomainName]}";

//            return HttpContext.Current.Request.Headers.AllKeys.Contains("Authorization") ? HttpContext.Current.Request.Headers.Get("Authorization")
//                  : _token;

//        }
//    }
//}