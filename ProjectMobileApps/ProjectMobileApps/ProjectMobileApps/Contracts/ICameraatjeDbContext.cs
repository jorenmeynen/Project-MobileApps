using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMobileApps.Contracts
{
    public interface ICameraatjeDbContext
    {
        DbSet<Toddler> Toddlers { get; set; }
        DbSet<Picture> Pictures { get; set; }
        DbSet<Corner> Corners { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
