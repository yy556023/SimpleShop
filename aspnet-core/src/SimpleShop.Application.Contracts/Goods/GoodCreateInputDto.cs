using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Goods
{
    public class GoodCreateInputDto
    {
        public string Name { get; set; } = string.Empty;
        public Guid Category { get; set; } = Guid.Empty;
        public decimal Price { get; set; } = default;
        public int Quantity { get; set; } = default;
    }
}