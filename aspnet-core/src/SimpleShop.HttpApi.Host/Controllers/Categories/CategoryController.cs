using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.Application.Contracts.Categories;

namespace SimpleShop.HttpApi.Host.Controllers.Categories
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }

        [HttpPost]
        public Task<CategoryDto> CreateAsync(CategoryCreateInputDto input)
        {
            return _categoryAppService.CreateAsync(input);
        }
    }
}