using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Domain.Goods
{
    public class GoodManager
    {
        public Good Create(Guid id, string name, Guid category, decimal price, int quantity){
            return new Good(
                id: id,
                name: name,
                category: category,
                price: price,
                quantity: quantity
            );
        }
    }
}