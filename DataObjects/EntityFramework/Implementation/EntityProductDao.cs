using BusinessObjects;
using DataObjects.EntityFramework.ModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework.Implementation
{
    public class EntityProductDao : IProductDao
    {
        /// <summary>
        /// Gets List of Products
        /// </summary>
        /// <returns>List of Products</returns>
        public List<Product> GetProducts() {
            using(var context = DataObjectFactory.CreateContext()){

                var list = new List<Product>();
                var products = context.Products.ToList();

                foreach (var entity in products)
                    list.Add(Mapper.Map(entity));

                return list;
            }
        }
    }
}
