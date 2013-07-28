using DataObjects.EntityFramework.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public static class DataAccess
    {
        private static readonly IDaoFactory _factory = new EntityDaoFactory();
        public static IProductDao ProductDao {
            get { return _factory.ProductDao; }
        }
    }
}
