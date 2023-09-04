using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Categories
{
    public interface ICategoryAppService
    {
        Task<CategoryDto> CreateAsync(CategoryCreateInputDto input);
    }
}