using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

using Newtonsoft.Json;

using Redis.Utilities.Helper;

using RedisSessionState_Poc.Models;
using RedisSessionState_Poc.ViewModels;

namespace RedisSessionState_Poc.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        private readonly string jsonObj = "{'UserId':2,'WishList':[],'Email':'admin@znode.com','AspNetUserId':'ab9ac88f-cdeb-4ddd-a7e7-9193d71cc91d','ExternalId':'0','Profiles':[],'OrderList':[],'Addresses':[{'AddressId':2,'Address1':'7500 W 110TH ST ','DisplayName':'Default Address','FirstName':'Site','LastName':'Admin','CountryName':'US','StateName':'KS','CityName':'OVERLAND PARK','PostalCode':'66210','PhoneNumber':'1234567890','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'1/18/2017 1:42:17 PM','ModifiedBy':2,'ModifiedDate':'4/19/2018 1:47:23 PM'},{'AddressId':42,'Address1':'7500 W 110TH ST ','DisplayName':'bad address','FirstName':'test','LastName':'test','CountryName':'US','StateName':'KS','CityName':'OVERLAND PARK','PostalCode':'66210','PhoneNumber':'1234567890','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'1/26/2018 6:48:29 PM','ModifiedBy':2,'ModifiedDate':'2/1/2018 1:33:32 PM'},{'AddressId':43,'Address1':'7500 W 110th Street','DisplayName':'SPP','FirstName':'Some','LastName':'Guy','CountryName':'US','StateName':'KS','CityName':'Overland Park','PostalCode':'66210','PhoneNumber':'321321321312','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'1/26/2018 7:41:12 PM','ModifiedBy':2,'ModifiedDate':'4/19/2018 1:42:57 PM'},{'AddressId':44,'Address1':'7500 W 110TH ST ','DisplayName':'Kansas address','FirstName':'Manish','LastName':'M','CountryName':'US','StateName':'KS','CityName':'OVERLAND PARK','PostalCode':'66210','PhoneNumber':'4142100406','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'1/26/2018 3:26:31 PM','ModifiedBy':2,'ModifiedDate':'4/19/2018 1:43:30 PM'},{'AddressId':45,'Address1':'7500 W 110TH ST ','DisplayName':'Test address','FirstName':'Manish ','LastName':'M','CountryName':'US','StateName':'KS','CityName':'OVERLAND PARK','PostalCode':'66210','PhoneNumber':'4142100406','Countries':[],'UserId':2,'States':[],'CompanyName':' ','CreatedBy':2,'CreatedDate':'1/29/2018 8:19:08 AM','ModifiedBy':2,'ModifiedDate':'2/12/2018 3:22:38 PM'},{'AddressId':46,'Address1':'5955 HAWTHORNE DR ','DisplayName':'kathy w','FirstName':'kathy','LastName':'warniment','CountryName':'US','StateName':'OH','CityName':'SYLVANIA','PostalCode':'43560','PhoneNumber':'4198612109','Countries':[],'UserId':2,'States':[],'CompanyName':'staples promo','CreatedBy':2,'CreatedDate':'2/2/2018 1:15:47 PM','ModifiedBy':2,'ModifiedDate':'2/8/2018 8:22:50 AM'},{'AddressId':110,'Address1':'527 PLEASANT HILL RD LOT B','DisplayName':'Danny Boyle','FirstName':'Danny','LastName':'Boyle','CountryName':'US','StateName':'LA','CityName':'JENA','PostalCode':'71342-3928','PhoneNumber':'123456789','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'4/19/2018 1:47:23 PM','ModifiedBy':2,'ModifiedDate':'7/3/2018 12:50:44 AM'},{'AddressId':216,'Address1':'208 MELROSE ST ','DisplayName':'David','FirstName':'David','LastName':'Willey','CountryName':'US','StateName':'MA','CityName':'MELROSE','PostalCode':'02176-1720','PhoneNumber':'4100000000','Countries':[],'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'7/3/2018 12:11:58 AM','ModifiedBy':2,'ModifiedDate':'7/3/2018 12:11:58 AM'},{'AddressId':219,'Address1':'720 N. Old World 3rd st.','Address2':'test','DisplayName':'Znode','FirstName':'David','LastName':'Willey','CountryName':'AI','StateName':'UT','CityName':'Milwaukee','PostalCode':'53203','PhoneNumber':'8008675309','Countries':[],'UserId':2,'States':[],'CompanyName':'Znode','CreatedBy':2,'CreatedDate':'7/3/2018 12:50:44 AM','ModifiedBy':2,'ModifiedDate':'7/3/2018 3:53:51 AM'},{'AddressId':227,'Address1':'720 N OLD WORLD 3RD ST TEST','DisplayName':'Znode','FirstName':'David','LastName':'Willey','CountryName':'DZ','StateName':'1','CityName':'MILWAUKEE','PostalCode':'53203-2237','PhoneNumber':'8008675309','Countries':[],'UserId':2,'States':[],'CompanyName':'Znode','CreatedBy':2,'CreatedDate':'7/3/2018 3:53:51 AM','ModifiedBy':2,'ModifiedDate':'8/22/2018 5:28:29 AM'},{'AddressId':311,'Address1':'7500 W 110TH ST','DisplayName':'Staples Address','FirstName':'Manish ','LastName':'M','CountryName':'US','StateName':'KS','CityName':'OVERLAND PARK','PostalCode':'66210-2372','PhoneNumber':'4142695452','Countries':[],'IsDefaultBilling':true,'IsDefaultShipping':true,'IsShipping':true,'IsBilling':true,'UserId':2,'States':[],'CreatedBy':2,'CreatedDate':'8/22/2018 5:28:29 AM','ModifiedBy':2,'ModifiedDate':'8/22/2018 5:28:29 AM'}],'GiftCardHistory':[],'VoucherList':[],'FullName':'admin znode','FirstName':'admin','LastName':'znode','RoleName':'Admin','ReferralCommissionData':{},'PublishCatalogId':34,'Custom1':'','Permission':true,'IsApprover':true,'UserGlobalAttributes':[{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':5,'GlobalAttributeId':119,'AttributeTypeId':13,'AttributeTypeName':'Number','AttributeCode':'PerOrderLimit','AttributeName':'Per Order Limit','ControlName':'Yes/No','ValidationName':'AllowNegative','ValidationValue':'false','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':5,'GlobalAttributeId':119,'AttributeTypeId':13,'AttributeTypeName':'Number','AttributeCode':'PerOrderLimit','AttributeName':'Per Order Limit','ControlName':'Yes/No','ValidationName':'AllowDecimals','ValidationValue':'true','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':5,'GlobalAttributeId':119,'AttributeTypeId':13,'AttributeTypeName':'Number','AttributeCode':'PerOrderLimit','AttributeName':'Per Order Limit','ControlName':'Number','ValidationName':'MinNumber','ValidationValue':'','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':5,'GlobalAttributeId':119,'AttributeTypeId':13,'AttributeTypeName':'Number','AttributeCode':'PerOrderLimit','AttributeName':'Per Order Limit','ControlName':'Number','ValidationName':'MaxNumber','ValidationValue':'','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':5,'GlobalAttributeId':120,'AttributeTypeId':13,'AttributeTypeName':'Number','AttributeCode':'PerOrderAnnualLimit','AttributeName':'Annual Order Limit','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':7,'GlobalAttributeId':122,'AttributeTypeId':5,'AttributeTypeName':'Text','AttributeCode':'BillingAccountNumber','IsLocalizable':true,'AttributeName':'Billing Account Number','IsRegExp':false},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':8,'GlobalAttributeId':123,'AttributeTypeId':7,'AttributeTypeName':'Yes/No','AttributeCode':'EnableUserShippingAddressSuggestion','IsLocalizable':true,'AttributeName':'Enable Shipping Address Suggestion','AttributeDefaultValueCode':'true','AttributeDefaultValue':'true','IsEditable':true,'IsRegExp':false,'HelpDescription':'Enable Shipping Address suggestion list for the user on the checkout page in webstore'},{'GlobalEntityId':2,'EntityName':'user','EntityValue':'admin znode','GlobalAttributeGroupId':21,'GlobalAttributeId':193,'AttributeTypeId':7,'AttributeTypeName':'Yes/No','AttributeCode':'EnablePowerBIReportOnWebStore','IsLocalizable':true,'AttributeName':'Enable Power BI Report On WebStore','IsRegExp':false,'HelpDescription':'Enable Power BI Report On WebStore'}],'ProfileList':[],'IsAdminUser':true,'IsVerified':true,'CreatedBy':2,'CreatedDate':'6/2/2016 8:00:57 AM','ModifiedBy':2,'ModifiedDate':'02/28/2022'}";

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult ClearSession(string returnUrl)
        {
            HttpContext.Session.Remove("UserObject");
            return RedirectToAction("Login", new { ReturnUrl = returnUrl });
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Models.LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    {
                        SessionHelper.SaveDataInSession<String>("UserEmail", model.Email);

                        var userViewModel = JsonConvert.DeserializeObject<UserViewModel>(jsonObj);
                        SessionHelper.SaveDataInSession<UserViewModel>("UserObject", userViewModel);

                        return RedirectToLocal(returnUrl);
                    }
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        //
        // GET: /Account/VerifyCode
        [AllowAnonymous]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl, bool rememberMe)
        {
            // Require that the user has already logged in via username/password or external login
            if (!await SignInManager.HasBeenVerifiedAsync())
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes. 
            // If a user enters incorrect codes for a specified amount of time then the user account 
            // will be locked out for a specified amount of time. 
            // You can configure the account lockout settings in IdentityConfig
            var result = await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent: model.RememberMe, rememberBrowser: model.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid code.");
                    return View(model);
            }
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(Models.RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return RedirectToAction("Index", "Home");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var result = await UserManager.ConfirmEmailAsync(userId, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View("ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);		
                // await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");
                // return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            AddErrors(result);
            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/SendCode
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
            {
                return View("Error");
            }
            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Generate the token and send it
            if (!await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }
            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });
                case SignInStatus.Failure:
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}