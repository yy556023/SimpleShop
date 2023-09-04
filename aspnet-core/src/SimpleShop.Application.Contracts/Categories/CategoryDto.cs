using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Application.Contracts.Commons;

namespace SimpleShop.Application.Contracts.Categories
{
    public class CategoryDto : AggregateDto
    {
        public string Name { get; set; } = string.Empty;
    }
}