namespace RedisSessionState_Poc.ViewModels
{
    public class CaseRequestViewModel : BaseViewModel
    {
        public int CaseRequestID { get; set; }
        public int PortalId { get; set; }
        public int? UserId { get; set; }
        public int CaseStatusId { get; set; }
        public int CasePriorityId { get; set; }
        public int CaseTypeId { get; set; }
        public string CaseOrigin { get; set; }

        public string Description { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailID { get; set; }
        public string PhoneNumber { get; set; }

        public bool AllowSharingWithCustomer { get; set; }
        public string Message { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public int LocaleId { get; set; }
    }
}