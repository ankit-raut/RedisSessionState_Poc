using System.Collections.Generic;

namespace RedisSessionState_Poc.Models
{
    public class BaseDropDownList
    {
        public string id { get; set; }

        public int DataId { get; set; }

        public string name { get; set; }

        public bool Ischecked { get; set; }

        public bool HasSublist { get; set; }

        public List<BaseDropDownList> Sublist { get; set; }
    }
}