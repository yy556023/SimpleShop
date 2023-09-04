using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Commoms;

namespace SimpleShop.Domain.Categories
{
    public class Category : AggregateRoot
    {
        public string Name { get; set; } = string.Empty;

        internal Category(Guid id, string name)
        {
            Id = id;
            Name = name;
            Creator = "Admin";
            CreateDate = DateTime.UtcNow;
        }

        private Category()
        {

        }
    }
}