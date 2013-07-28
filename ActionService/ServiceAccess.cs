using ActionService.ViewModel;
using BusinessObjects;
using Cart;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ActionService
{
    public class ServiceAccess : IServiceAccess
    {
        private IProductDao _productDao = DataAccess.ProductDao;
        public ProductResponse DisplayProducts()
        {
            var scart = new ShoppingCart();
            scart.AddItem(1, "xyz", 5, 12.5);
            return new ProductResponse
            {
                Products = _productDao.GetProducts(),
                ShoppingCart = scart,
                Categories = GetCategories(),
                SelectedCategoryIds = new List<int>{ 2 }
                 
            };
        }

        private List<Category> GetCategories()
        {
            return new List<Category> {
                new Category{ CategoryId = 1, Name = "Books"},
                new Category{ CategoryId = 2, Name = "Vehicles"}
            };
        }


        public ShoppingCart DisplayCart()
        {
            var scart = new ShoppingCart();
            scart.AddItem(1, "xyz", 5, 12.5);
            return scart;
        }
    }
}
