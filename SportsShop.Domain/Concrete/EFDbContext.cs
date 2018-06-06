using SportsShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsShop.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EFDbContext() {

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
