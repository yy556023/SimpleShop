using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SimpleShop.Application.Contracts.Goods;
using SimpleShop.Domain.Goods;

namespace SimpleShop.Application.Goods
{
    public class GoodAppService : IGoodAppService
    {
        private readonly IConfiguration _configuraiton;
        private readonly IGoodRepository _goodRepository;
        private readonly GoodAdapter _goodAdapter;
        private readonly GoodManager _goodManager;

        public GoodAppService(
            IConfiguration configuraiton,
            IGoodRepository goodRepository,
            GoodAdapter goodAdapter,
            GoodManager goodManager
            )
        {
            _configuraiton = configuraiton;
            _goodRepository = goodRepository;
            _goodAdapter = goodAdapter;
            _goodManager = goodManager;
        }

        public async Task<GoodGetListResultDto> GetListAsync(GoodGetListInputDto input)
        {
            var goodlist = await _goodRepository.GetListAsync(input.Filter, input.Skip, input.Take);
            var goodcount = await _goodRepository.GetCountAsync(input.Filter);

            return new GoodGetListResultDto
            {
                Items = _goodAdapter.EntityToDtoList(goodlist),
                Count = goodcount
            };
        }

        public async Task<GoodDto> GetAsync(Guid id)
        {
            var good = await _goodRepository.GetAsync(id) ?? _goodManager.Create(
                id: Guid.NewGuid(),
                name: "產品1",
                category: Guid.Empty,
                price: 100,
                quantity: 100
            );

            return _goodAdapter.EntityToDto(good);
        }

        public async Task<GoodDto> CreateAsync(GoodCreateInputDto input){
            var good = _goodManager.Create(
                id: Guid.NewGuid(),
                name: input.Name,
                category: input.Category,
                price: 100,
                quantity: 100
            );

            good = await _goodRepository.InsertAsync(good);

            return _goodAdapter.EntityToDto(good);
        }
    }
}