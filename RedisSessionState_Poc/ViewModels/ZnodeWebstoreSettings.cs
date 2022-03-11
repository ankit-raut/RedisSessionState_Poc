using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Web;

namespace RedisSessionState_Poc
{
    public static class ZnodeWebstoreSettings
    {
        private static NameValueCollection settings = ConfigurationManager.AppSettings;

        public static void SetConfigurationSettingSource(NameValueCollection settingSource)
        {
            settings = settingSource;
        }

        public static string ZnodeApiRootUri
        {
            get
            {
                return Convert.ToString(settings["ZnodeApiRootUri"]);
            }
        }

        public static string PaymentApplicationUrl
        {
            get
            {
                return Convert.ToString(settings["PaymentApplicationUrl"]);
            }
        }

        public static string ZnodeApiUriItemSeparator
        {
            get
            {
                return Convert.ToString(settings["ZnodeApiUriItemSeparator"]);
            }
        }

        public static string ZnodeApiUriKeyValueSeparator
        {
            get
            {
                return Convert.ToString(settings["ZnodeApiUriKeyValueSeparator"]);
            }
        }

        public static string TotalBrandCount
        {
            get
            {
                return Convert.ToString(settings["TotalBrandsCount"]);
            }
        }

        public static string ZnodeWebStoreUri
        {
            get
            {
                return Convert.ToString(HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority);
            }
        }

        public static string ZnodeWebStoreUriSocialLogin
        {
            get
            {
                return Convert.ToString(settings["ZnodeWebStoreUriSocialLogin"]);
            }
        }

        public static string ZnodeGoogleMapKey
        {
            get
            {
                return Convert.ToString(settings["ZnodeGoogleMapKey"]);
            }
        }

        public static string ZnodeGocoderGoogleAPI
        {
            get
            {
                return Convert.ToString(settings["ZnodeGocoderGoogleAPI"]);
            }
        }

        public static string ZnodeGoogleAPIDomainKey
        {
            get
            {
                return Convert.ToString(settings["ZnodeGoogleAPIDomainKey"]);
            }
        }

        /// <summary>
        /// Disable the default startup page navigation to the portal selection page while executing in debug mode.
        /// NULL/"False" : Navigation to the portal selection page in DEBUG mode over URL:"/Dev/PortalSelection" or [Startup] will be enabled.
        /// "True" : Navigation to the portal selection page on [Startup] will be disabled. Default navigation to "/Home/Index" will be available.
        /// </summary>
        public static string DisablePortalSelection
        {
            get
            {
                return Convert.ToString(settings["DisablePortalSelection"]);
            }
        }
        public static string CSPAvailableThemes
        {
            get
            {
                return Convert.ToString(settings["CSPAvailableThemes"]);
            }
        }

        public static string SEOSlugToSkip
        {
            get
            {
                return Convert.ToString(settings["SEOSlugToSkip"]);
            }
        }

        public static bool RunAllManagedModules
        {
            get
            {
                return Convert.ToBoolean(settings["RunAllManagedModules"]);
            }
        }
        public static bool EnableScriptOptimizations
        {
            get
            {
                return Convert.ToBoolean(settings["EnableScriptOptimizations"]);
            }
        }
        public static bool IsGlobalAPIAuthorization
        {
            get
            {
                return Convert.ToBoolean(settings["IsGlobalAPIAuthorization"]);
            }
        }
        public static string ZnodePaymentApiDomainName
        {
            get
            {
                return Convert.ToString(settings["ZnodePaymentApiDomainName"]);
            }
        }
        public static string ZnodePaymentApiDomainKey
        {
            get
            {
                return Convert.ToString(settings["ZnodePaymentApiDomainKey"]);
            }
        }

		public static bool EnableTokenBasedAuthorization
		{
			get
			{
				return Convert.ToBoolean(settings["EnableTokenBasedAuthorization"]);
			}
		}
        public static string HomeController
        {
            get
            {
                if (string.IsNullOrEmpty(settings["CustomHomePageUrl"]))
                    return "Home";
                string[] controllerActionValue = settings["CustomHomePageUrl"].Split(',');
                return string.IsNullOrEmpty(controllerActionValue[0]) ? "Home" : controllerActionValue[0];
            }
        }
        public static string HomeAction
        {
            get
            {
                if (string.IsNullOrEmpty(settings["CustomHomePageUrl"]))
                    return "Index";
                string[] controllerActionValue = settings["CustomHomePageUrl"].Split(',');
                return string.IsNullOrEmpty(controllerActionValue[1]) ? "Index" : controllerActionValue[1];
            }
        }

        public static string SplashScreenAction
        {
            get
            {
                if (string.IsNullOrEmpty(settings["CustomSplashScreenPageUrl"]))
                    return "SplashScreen";
                string[] controllerActionValue = settings["CustomSplashScreenPageUrl"].Split(',');
                return string.IsNullOrEmpty(controllerActionValue[1]) ? "SplashScreen" : controllerActionValue[1];
            }
        }
        public static string LoginPageUrl
        {
            get
            {
                return string.IsNullOrEmpty(settings["CustomLoginPageUrl"]) ?
                             "/User/Login" : settings["CustomLoginPageUrl"];
            }
        }

        public static bool MinifiedJsonResponse
        {
            get
            {
                return Convert.ToBoolean(settings["MinifiedJsonResponseFromAPI"]);
            }
        }
        public static string PowerBIAuthorityUrl
        {
            get
            {
                return Convert.ToString(settings["PowerBIAuthorityUrl"]);
            }
        }

        public static string PowerBIResourceUrl
        {
            get
            {
                return Convert.ToString(settings["PowerBIResourceUrl"]);
            }
        }

        public static string PowerBIApiUrl
        {
            get
            {
                return Convert.ToString(settings["PowerBIApiUrl"]);
            }
        }

        public static string ZnodeApiDomainName
        {
            get
            {
                return Convert.ToString(settings["ZnodeApiDomainName"]);
            }
        }

        public static string ZnodeApiDomainKey
        {
            get
            {
                return Convert.ToString(settings["ZnodeApiDomainKey"]);
            }
        }

        public static string ArtifiImageHeight
        {
            get
            {
                return Convert.ToString(settings["ArtifiImageHeight"]);
            }
        }

        public static string ArtifiImageWidth
        {
            get
            {
                return Convert.ToString(settings["ArtifiImageWidth"]);
            }
        }

        public static string TaxExemptCertificateAzureBucketName
        {
            get
            {
                return Convert.ToString(settings["TaxExemptCertificateAzureBucketName"]);
            }
        }
    }
}