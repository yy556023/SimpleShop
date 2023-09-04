using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.Application.Contracts.Goods;

namespace SimpleShop.HttpApi.Host.Controllers.Goods
{
    [ApiController]
    [Route("api/good")]
    public class GoodController : ControllerBase, IGoodAppService
    {
        private readonly IGoodAppService _goodAppService;

        public GoodController(IGoodAppService goodAppService)
        {
            _goodAppService = goodAppService;
        }

        [HttpGet]
        public Task<GoodGetListResultDto> GetListAsync([FromQuery] GoodGetListInputDto input)
        {
            return _goodAppService.GetListAsync(input);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<GoodDto> GetAsync(Guid id)
        {
            return _goodAppService.GetAsync(id);
        }

        [HttpPost]
        public Task<GoodDto> CreateAsync(GoodCreateInputDto input)
        {
            return _goodAppService.CreateAsync(input);
        }
    }
}