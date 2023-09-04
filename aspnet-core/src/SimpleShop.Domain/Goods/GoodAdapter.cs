using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Application.Contracts.Goods;

namespace SimpleShop.Domain.Goods
{
    public class GoodAdapter
    {
        public GoodDto EntityToDto(Good entity){
            return new GoodDto
            {
                Id = entity.Id,
                Category = entity.Category,
                Name = entity.Name,
                Price = entity.Price,
                Quantity = entity.Quantity,
                Creator = entity.Creator,
                CreateDate = entity.CreateDate
            };
        }

        public List<GoodDto> EntityToDtoList(List<Good> entities){
            var dtoList = new List<GoodDto>();

            foreach (var item in entities)
            {
                var dto = new GoodDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity
                };

                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}