using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.EntityFramework
{
    /// <summary>
    /// Create context object on the fly
    /// </summary>
    public class DataObjectFactory
    {

        public static eCommerceEntities CreateContext()
        {
            return new eCommerceEntities();
        }
    }
}
