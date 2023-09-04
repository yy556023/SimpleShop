using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Goods
{
    public interface IGoodAppService
    {
        Task<GoodGetListResultDto> GetListAsync(GoodGetListInputDto input);

        Task<GoodDto> GetAsync(Guid id);

        Task<GoodDto> CreateAsync(GoodCreateInputDto input);
    }
}