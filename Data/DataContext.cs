using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
using UsersApi.Models;

namespace ProductsApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; init; }
        public DbSet<User> Users { get; init; }
    }
}