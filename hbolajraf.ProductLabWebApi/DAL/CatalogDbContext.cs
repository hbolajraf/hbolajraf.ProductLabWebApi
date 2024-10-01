using hbolajraf.ProductLabWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace hbolajraf.ProductLabWebApi.DAL
{
    public class CatalogDbContext : DbContext
    {

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
