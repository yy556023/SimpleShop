using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Commons
{
    public class FullAggregateDto : AggregateDto
    {
        public string? Deletor { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}