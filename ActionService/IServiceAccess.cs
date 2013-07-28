using ActionService.ViewModel;
using Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService
{
    public interface IServiceAccess
    {
        ProductResponse DisplayProducts();

        ShoppingCart DisplayCart();
    }
}
