using System.ComponentModel.DataAnnotations;


namespace RedisSessionState_Poc.ViewModels
{
    public class UserOrderViewModel : BaseViewModel
    {
        public string OrderNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
    }
}
