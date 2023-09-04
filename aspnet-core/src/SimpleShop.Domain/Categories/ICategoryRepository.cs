using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Domain.Categories
{
    public interface ICategoryRepository
    {
        Task<Category> InsertAsync(Category entity);
    }
}