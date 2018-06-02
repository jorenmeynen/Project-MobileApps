using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMobileApps.Contracts
{
    public interface IToddlerDbContext
    {
        DbSet<Toddler> Toddlers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellation = default(CancellationToken));
    }
}
