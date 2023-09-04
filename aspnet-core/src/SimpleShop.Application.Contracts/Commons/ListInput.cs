using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Commons
{
    public class ListInput
    {
        public string? Filter { get; set; }
        public int Skip { get; set; } = 1;
        public int Take { get; set; } = 10;
    }
}