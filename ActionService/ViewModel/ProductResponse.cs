using BusinessObjects;
using Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ActionService.ViewModel
{
    public class ProductResponse
    {

        /// <summary>
        /// Gets product
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets products
        /// </summary>
        public IList<Product> Products { get; set; }

        /// <summary>
        /// Gets Categories
        /// </summary>
        public List<Category> Categories { get; set; }

        [Display(Name = "Product Category")]
        public int SelectedCategoryId { get; set; }


        [Display(Name = "Product Category")]
        public IEnumerable<int> SelectedCategoryIds { get; set; }

        public IEnumerable<SelectListItem> CategoryItems
        {
            get { return new SelectList(Categories, "CategoryId", "Name"); }
        }

        /// <summary>
        /// Shopping cart
        /// </summary>
        public ShoppingCart ShoppingCart { get; set; }
    }
}
