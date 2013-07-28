using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataObjects.EntityFramework
{
    public class eCommerceEntities : DbContext
    {
        public eCommerceEntities() : base("name=eCommerceConnection") { }

        public DbSet<EntityCategory> Categories { get; set; }
        public DbSet<EntityProduct> Products { get; set; }
        public DbSet<EntityOrder> Orders { get; set; }
        public DbSet<EntityOrderDetail> OrderDetails { get; set; }
    }
}
