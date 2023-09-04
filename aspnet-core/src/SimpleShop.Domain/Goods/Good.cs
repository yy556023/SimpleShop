using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Commoms;

namespace SimpleShop.Domain.Goods
{
    public class Good : AggregateRoot
    {
        public string Name { get; set; } = string.Empty;
        public Guid Category { get; set; } = Guid.Empty;
        public decimal Price { get; set; } = default;
        public int Quantity { get; set; } = default;

        internal Good(Guid id, string name, Guid category, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            Creator = "Admin";
            CreateDate = DateTime.UtcNow;
        }

        private Good(){

        }
    }
}