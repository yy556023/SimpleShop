using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.EntityFrameworkCore.Commons
{
    public static class PageResultExtension
    {
        public static IQueryable<T> ToPageResult<T>(this IQueryable<T> source, int pageIndex, int pageSize)
        {
            return source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public static IEnumerable<T> ToPageResult<T>(this IEnumerable<T> source, int pageIndex, int pageSize)
        {
            return source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }
    }
}
