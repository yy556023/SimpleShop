using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Commoms;

namespace SimpleShop.Domain.Orders
{
    public class Order : FullAggregateRoot
    {
        public Guid UserId { get; set; } = Guid.Empty;
        public decimal TotalPrice { get; set; } = default;
    }
}