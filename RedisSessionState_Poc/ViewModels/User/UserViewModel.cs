using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Znode.Engine.Api.Models;


namespace RedisSessionState_Poc.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public List<WishListViewModel> WishList { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
        public string BaseUrl { get; set; }
        
        public string AspNetUserId { get; set; }
        
        public string ExternalId { get; set; }

        public int? AccountId { get; set; }

        public List<ProfileModel> Profiles { get; set; }
        public List<OrdersViewModel> OrderList { get; set; }
        public List<AddressViewModel> Addresses { get; set; }
        public List<GiftCardHistoryViewModel> GiftCardHistory { get; set; }
        public List<VoucherViewModel> VoucherList { get; set; }
        
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string RoleName { get; set; }
        public string CustomerPaymentGUID { get; set; }
        
        public string PermissionCode { get; set; }
        public bool EmailOptIn { get; set; }
        public int ReviewCount { get; set; }
        public int VoucherCount { get; set; }
        public string VoucherRemainingBalance { get; set; }
        public decimal? BudgetAmount { get; set; }
        public UserViewModel()
        {
            Profiles = new List<ProfileModel>();
            OrderList = new List<OrdersViewModel>();
            Addresses = new List<AddressViewModel>();
            GiftCardHistory = new List<GiftCardHistoryViewModel>();
            ReferralCommissionData = new ReferralCommissionViewModel();
            ProfileList = new List<SelectListItem>();
            VoucherList = new List<VoucherViewModel>();
        }
        public AddressViewModel BillingAddress { get; set; }
        public AddressViewModel ShippingAddress { get; set; }
        public int? PaymentSettingId { get; set; }

        public ReferralCommissionViewModel ReferralCommissionData { get; set; }

        public int? PublishCatalogId { get; set; }
        public int GuestUserId { get; set; }
        [AllowHtml]
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string Custom4 { get; set; }
        public string Custom5 { get; set; }

        public bool Permission
        {
            get
            {
                if (!string.Equals(this.RoleName, ZnodeRoleEnum.Manager.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    && !string.Equals(this.RoleName, ZnodeRoleEnum.User.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    return true;
                else
                    return false;
            }
        }
        
        public string BillingAccountNumber { get; set; }
        public decimal PerOrderLimit { get; set; }
        public decimal AnnualOrderLimit { get; set; }
        public decimal AnnualBalanceOrderAmount { get; set; }
        public bool IsApprover { get; set; }
        public bool HasApprovers { get; set; }

        public IEnumerable<GlobalAttributeValuesModel> UserGlobalAttributes { get; set; }
        public int PendingOrdersCount { get; set; }
        public int PendingPaymentCount { get; set; }
        public int PendingApprovalHistoryCount { get; set; }
        public int ProfileId { get; set; }
        public List<SelectListItem> ProfileList { get; set; }
        public bool IsAdminUser { get; set; }
        public bool IsVerified { get; set; }
    }
}