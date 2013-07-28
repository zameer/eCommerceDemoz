using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework.ModelMapper
{
    public class Mapper
    {
        internal static Product Map(EntityProduct entity)
        {
            return new Product { 
                ProductId = entity.ProductId,
                ProductName = entity.ProductName,
                UnitPrice = entity.UnitPrice,
                UnitsInStock = entity.UnitsInStock,
                CategoryId = entity.CategoryId,
                Weight = entity.Weight
            };
        }
    }
}
