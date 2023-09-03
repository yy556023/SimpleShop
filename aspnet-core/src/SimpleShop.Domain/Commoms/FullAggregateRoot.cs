using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Domain.Commoms
{
    public class FullAggregateRoot : AggregateRoot
    {
        public string? Deletor { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}