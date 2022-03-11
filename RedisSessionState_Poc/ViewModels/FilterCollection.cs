using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedisSessionState_Poc.ViewModels
{
    public class FilterCollection : List<FilterTuple>
    {
        public void Add(string filterName, string filterOperator, string filterValue) => Add(new FilterTuple(filterName, filterOperator, filterValue));
    }
}