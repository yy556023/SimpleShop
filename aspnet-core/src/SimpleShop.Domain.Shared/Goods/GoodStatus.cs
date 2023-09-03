using System.ComponentModel.DataAnnotations;

namespace SimpleShop.Domain.Shared.Goods
{
    public enum GoodStatus
    {
        [Display(Name = "現貨")]
        InStock = 1,

        [Display(Name = "售完")]
        SoldOut = 2,
    }
}