using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    /// <summary>
    /// Product Data access methods
    /// </summary>
    public interface IProductDao
    {
        /// <summary>
        /// Gets List of Products
        /// </summary>
        /// <returns>List of Products</returns>
        List<Product> GetProducts();
    } 
}
