using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Commoms;

namespace SimpleShop.Domain.OrderDetails
{
    public class OrderDetail : Entity
    {
        public Guid OrderId { get; set; } = Guid.Empty;
        public string GoodName { get; set; } = string.Empty;
        public decimal GoodPrice { get; set; } = default;
    }
}