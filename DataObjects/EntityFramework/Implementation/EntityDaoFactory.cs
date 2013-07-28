using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework.Implementation
{
    public class EntityDaoFactory : IDaoFactory
    {
        public IProductDao ProductDao {
            get { return new EntityProductDao(); } 
        }
    }
}
