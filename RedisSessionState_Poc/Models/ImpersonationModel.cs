using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisSessionState_Poc.Models
{
    public class ImpersonationModel
    {
        public string Token { get; set; }
        public int PortalId { get; set; }
        public int CRSUserId { get; set; }
        public string CRSName { get; set; }
        public int WebstoreUserId { get; set; }
        public string ShopperName { get; set; }
        public bool IsImpersonation { get; set; }
        public string UserName { get; set; }
    }
}
