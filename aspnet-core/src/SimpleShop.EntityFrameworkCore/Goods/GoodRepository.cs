using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleShop.Domain.Goods;
using SimpleShop.EntityFrameworkCore.Commons;
using SimpleShop.EntityFrameworkCore.EntityFrameworkCore;

namespace SimpleShop.EntityFrameworkCore.Goods
{
    public class GoodRepository : IGoodRepository
    {
        private readonly SimpleShopDbContext _context;

        public GoodRepository()
        {
            _context = GetDbContext();
        }

        public async Task<List<Good>> GetListAsync(string? filter, int skip = 1, int take = 10)
        {
            var goodList = await _context.Goods.Where(good => filter == null || good.Name.Contains(filter))
                                               .ToPageResult(skip, take)
                                               .ToListAsync();

            return goodList;
        }

        public async Task<int> GetCountAsync(string? filter)
        {
            var goodCount = await _context.Goods.Where(good => filter == null || good.Name.Contains(filter))
                                                .CountAsync();

            return goodCount;
        }

        public async Task<Good> GetAsync(Guid id){
            var good = await _context.Goods.FindAsync(id);

            return good!;
        }

        public async Task<Good> InsertAsync(Good entity)
        {
            await _context.Goods.AddAsync(entity);
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