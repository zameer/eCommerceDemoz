using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public class ShoppingCart
    {
        // The shopping cart line items
        public IList<ShoppingCartItem> Items { get; private set; }

        // When cart is 'dirty' recalculations are required
        private bool _isDirty = false;

        /// <summary>
        /// Adds a product item to the shopping cart. 
        /// Items may already exist; in that case just add to quantity.
        /// </summary>
        /// <param name="id">Unique product identifier.</param>
        /// <param name="name">Product name.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="unitPrice">Unit price of product.</param>
        public void AddItem(int id, string name, int quantity, double unitPrice)
        {
            _isDirty = true;
            if (Items == null)
                Items = new List<ShoppingCartItem>();

            foreach (var item in Items)
            {
                if (item.Id == id)
                {
                    item.Quantity += quantity;
                    return;
                }
            }

            Items.Add(new ShoppingCartItem
            {
                Id = id,
                Name = name,
                Quantity = quantity,
                UnitPrice = unitPrice
            });
        }
    }
}
