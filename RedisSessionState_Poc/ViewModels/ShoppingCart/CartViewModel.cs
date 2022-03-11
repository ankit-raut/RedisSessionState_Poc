using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Znode.Engine.Api.Models;

using System.Linq;

namespace RedisSessionState_Poc.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public List<CartItemViewModel> ShoppingCartItems { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal TaxCost { get; set; }
        public decimal TaxRate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal Discount { get; set; }
        public string AdditionalInstruction { get; set; }
        public bool GiftCardApplied { get; set; }
        public string GiftCardMessage { get; set; }
        public string GiftCardNumber { get; set; }
        public string CurrencySuffix { get; set; }
        public string CustomerPaymentGUID { get; set; }
        public int OmsQuoteId { get; set; }
        public string OrderStatus { get; set; }
        public string ShippingResponseErrorMessage { get; set; }
        public bool IsValidShippingSetting { get; set; }
        public bool IsSinglePageCheckout { get; set; }
        public bool FreeShipping { get; set; }
        public int UserId { get; set; }
        public List<CouponViewModel> Coupons { get; set; }
        public List<VouchersViewModel> Vouchers { get; set; }
        public decimal GiftCardAmount { get; set; }
        public decimal BudgetAmount { get; set; }
        public string PermissionCode { get; set; }
        public string RoleName { get; set; }
        public OrderShippingModel Shipping { get; set; }
        public bool IsRequireApprovalRouting { get; set; }

        public bool IsLevelApprovedOrRejected { get; set; }
        public bool IsLastApprover { get; set; }
        public decimal ECertAmount { get; set; }
        public bool ECertificateApplied { get; set; }

        //This property is used to persist the estimated shipping details after refresh the cart page.
        public string ZipCode { get; set; }

        public PromotionListViewModel ShippingModel { get; set; }
        public string ShippingName { get; set; }

        public decimal TotalAdditionalCost { get; set; }
        public bool Permission
        {
            get
            {
                if (string.Equals(this.RoleName, ZnodeRoleEnum.Administrator.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    || string.Equals(this.RoleName, ZnodeRoleEnum.Manager.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    || string.Equals(this.PermissionCode, ZnodePermissionCodeEnum.DNRA.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    || (string.Equals(this.PermissionCode, ZnodePermissionCodeEnum.ARA.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(this.OrderStatus, ZnodeOrderStatusEnum.APPROVED.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    || (string.Equals(this.PermissionCode, ZnodePermissionCodeEnum.SRA.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    && (this.SubTotal <= this.BudgetAmount) || string.Equals(this.OrderStatus, ZnodeOrderStatusEnum.APPROVED.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    || string.Equals(this.RoleName, ZnodeRoleEnum.Customer.ToString(), StringComparison.CurrentCultureIgnoreCase)
                    || string.Equals(this.RoleName, ZnodeRoleEnum.Admin.ToString(), StringComparison.CurrentCultureIgnoreCase) || Equals(this.RoleName, null))
                    return true;
                else
                    return false;

            }
        }
        //public string BillingNumber
        //{
        //    get
        //    {
        //        return SessionHelper.GetDataFromSession<UserViewModel>(WebStoreConstants.UserAccountKey)?.BillingAccountNumber;
        //    }
        //}

        public bool EnableApprovalRouting
        {
            get; set;
        }

        public bool IsHighRadiusApprovalRouting
        {
            get
            {
                if (!ShowPlaceOrderButton && (string.Equals(PermissionCode, ZnodePermissionCodeEnum.ARA.ToString(), StringComparison.CurrentCultureIgnoreCase) || string.Equals(PermissionCode, ZnodePermissionCodeEnum.SRA.ToString(), StringComparison.CurrentCultureIgnoreCase)))
                    return true;
                else
                    return false;
            }
        }

        public bool ShowPlaceOrderButton
        {
            get; set;
        }
        public string CultureCode { get; set; }
        public string ApprovalType { get; set; }
        public string Token { get; set; }
        public DateTime? InHandDate { get; set; }
        public string JobName { get; set; }
        public string ShippingConstraintCode { get; set; }
        public IList<ShippingConstraintsViewModel> ShippingConstraints { get; set; }
        //Returns the list of shopping cart items to be sent to the datalayer while checkout.
        public virtual List<CartItemImpressionsViewModel> GetEcommerceCartItemsData()
        {
            List<CartItemImpressionsViewModel> impressions = ShoppingCartItems?
                .Select(x => new CartItemImpressionsViewModel() { SKU = x.SKU, Name = x.ProductName, ProductPrice = x.ExtendedPrice, Quantity = x.Quantity, Variant = x.ConfigurableProductSKUs }).ToList();
            return impressions ?? new List<CartItemImpressionsViewModel>();
        }
    }
}