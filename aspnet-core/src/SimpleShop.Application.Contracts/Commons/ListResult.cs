using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Commons
{
    public class ListResult<T>
    {
        public List<T>? Items { get; set; }
        public int Count { get; set; }
    }
}