using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SimpleShop.Application.Contracts.Categories;
using SimpleShop.Domain.Categories;

namespace SimpleShop.Application.Categories
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly IConfiguration _configuraiton;
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryAdapter _categoryAdapter;
        private readonly CategoryManager _categoryManager;

        public CategoryAppService(
            IConfiguration configuraiton,
            ICategoryRepository categoryRepository,
            CategoryAdapter categoryAdapter,
            CategoryManager categoryManager
            )
        {
            _configuraiton = configuraiton;
            _categoryRepository = categoryRepository;
            _categoryAdapter = categoryAdapter;
            _categoryManager = categoryManager;
        }
        public async Task<CategoryDto> CreateAsync(CategoryCreateInputDto input){
            var category = _categoryManager.Create(
                id: Guid.NewGuid(),
                name: input.Name
            );

            category = await _categoryRepository.InsertAsync(category);

            return _categoryAdapter.EntityToDto(category);
        }
    }
}