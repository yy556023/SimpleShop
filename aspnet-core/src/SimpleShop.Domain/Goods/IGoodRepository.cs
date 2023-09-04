using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Domain.Goods
{
    public interface IGoodRepository
    {
        Task<List<Good>> GetListAsync(string? filter, int skip = 1, int take = 10);

        Task<int> GetCountAsync(string? filter);

        Task<Good> GetAsync(Guid id);

        Task<Good> InsertAsync(Good entity);
    }
}