using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisSessionState_Poc.ViewModels
{
    public class FilterTuple : Tuple<string, string, string>
    {
        public string FilterName { get { return Item1; } }
        public string FilterOperator { get { return Item2; } }
        public string FilterValue { get { return Item3; } }

        public FilterTuple(string filterName, string filterOperator, string filterValue) : base(filterName, filterOperator, filterValue)
        {
        }
    }
}