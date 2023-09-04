using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Categories;
using SimpleShop.EntityFrameworkCore.EntityFrameworkCore;

namespace SimpleShop.EntityFrameworkCore.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SimpleShopDbContext _context;

        public CategoryRepository()
        {
            _context = GetDbContext();
        }

        public async Task<Category> InsertAsync(Category entity)
        {
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
            Console.Write("1");
            return entity;
        }

        private SimpleShopDbContext GetDbContext()
        {
            return new SimpleShopDbContextFactory().CreateDbContext(Array.Empty<string>());
        }
    }
}