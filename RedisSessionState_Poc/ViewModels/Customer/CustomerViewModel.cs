using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RedisSessionState_Poc.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string LoginName { get; set; }
        public bool IsConfirmed { get; set; }
        public int ProfileId { get; set; }
        public bool IsUserAdmin { get; set; }

        public string AspNetUserId { get; set; }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreateUser { get; set; }

        public string UserName { get; set; }

        public int? AccountId { get; set; }

        public int? DepartmentId { get; set; }

        public string ExternalId { get; set; }
        public string PermissionsName { get; set; }
        public string DepartmentName { get; set; }
        public string RoleName { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
        public string Custom3 { get; set; }
        public string CustomerPaymentGUID { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }

        public bool EmailOptIn { get; set; }
        public bool IsLock { get; set; }
        public List<SelectListItem> Portals { get; set; }
        public List<SelectListItem> Accounts { get; set; }
        public List<SelectListItem> Departments { get; set; }
        public List<SelectListItem> Roles { get; set; }
        public List<SelectListItem> Permissions { get; set; }
        public List<SelectListItem> UserApprovalList { get; set; }
        public string AccountPermissionList { get; set; }

        public decimal? BudgetAmount { get; set; }
        public string[] PortalIds { get; set; }
        public int? PortalId { get; set; }

        public string PermissionCode { get; set; }

        public int? ApprovalUserId { get; set; }

        public string RoleId { get; set; }
        public bool IsSelectAllPortal { get; set; }
        public bool IsGuestUser { get; set; }
        public int? AccountPermissionAccessId { get; set; }
        public string ApprovalName { get; set; }
        public int? AccountUserOrderApprovalId { get; set; }
        public string PermissionOptions { get; set; }

        public string StoreName { get; set; }
        public string AccountName { get; set; }
        public bool IsEmailSentFailed { get; set; }
        public string ShippingPostalCode { get; set; }
        public string BillingPostalCode { get; set; }

    }
}