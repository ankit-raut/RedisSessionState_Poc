﻿using System;

namespace RedisSessionState_Poc.ViewModels
{
    public class UserApproverViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public int ApproverLevelId { get; set; }
        public int ApproverUserId { get; set; }
        public int ApproverOrder { get; set; }
        public bool IsNotifyEmail { get; set; }
        public bool IsMandatory { get; set; }
        public int OmsOrderStateId { get; set; }
        public int OmsQuoteId { get; set; }
        public string ApproverName { get; set; }
        public string OmsOrderState { get; set; }
        public string ApproverLevelName { get; set; }
        public Nullable<DateTime> StatusModifiedDate { get; set; }
        public Nullable<decimal> ToBudgetAmount { get; set; }
        public Nullable<decimal> FromBudgetAmount { get; set; }
        public int PortalApprovalId { get; set; }
        public int PortalPaymentGroupId { get; set; }
    }
}
