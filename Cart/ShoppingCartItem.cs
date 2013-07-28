using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public class ShoppingCartItem
    {
        /// <summary>
        /// Unique identifier of the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Quantity of products.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Price per unit for product.
        /// </summary>
        public double UnitPrice { get; set; }
    }
}
