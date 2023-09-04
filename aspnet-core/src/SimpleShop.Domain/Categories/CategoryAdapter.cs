using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Application.Contracts.Categories;

namespace SimpleShop.Domain.Categories
{
    public class CategoryAdapter
    {
        public CategoryDto EntityToDto(Category entity)
        {
            return new CategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Creator = entity.Creator,
                CreateDate = entity.CreateDate
            };
        }

        public List<CategoryDto> EntityToDtoList(List<Category> entities)
        {
            var dtoList = new List<CategoryDto>();

            foreach (var item in entities)
            {
                var dto = new CategoryDto
                {
                    Id = item.Id,
                    Name = item.Name
                };

                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}