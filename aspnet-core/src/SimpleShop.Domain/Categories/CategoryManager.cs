using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Domain.Categories
{
    public class CategoryManager
    {
        public Category Create(Guid id, string name)
        {
            return new Category(
                id: id,
                name: name
            );
        }
    }
}