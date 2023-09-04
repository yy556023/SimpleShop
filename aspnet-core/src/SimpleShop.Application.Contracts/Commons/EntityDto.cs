using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Commons
{
    public class EntityDto
    {
        public Guid Id { get; set; } = Guid.Empty;
    }
}