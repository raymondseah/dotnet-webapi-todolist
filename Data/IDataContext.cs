using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
using UsersApi.Models;
namespace ProductsApi.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products { get; init; }
        DbSet<User> Users { get; init; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}