using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisSessionState_Poc
{
    public class AutoComplete
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DisplayText { get; set; }

        public Dictionary<string, object> Properties { get; set; }

        public AutoComplete()
        {
            Properties = new Dictionary<string, object>();
        }

    }
}