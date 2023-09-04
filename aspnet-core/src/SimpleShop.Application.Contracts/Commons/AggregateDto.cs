using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Application.Contracts.Commons
{
    public class AggregateDto : EntityDto
    {
        public string? Creator { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Updator { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}