using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Categories
{
    public class CategoryCreateInputDto
    {
        public required string Name { get; set; }
    }
}