using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Models;
using ProjectMobileApps.Contracts;

namespace ProjectMobileApps.Data
{
    public class CameraatjeDbContext : DbContext, ICameraatjeDbContext
    {
        public DbSet<Toddler> Toddlers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Corner> Corners { get; set; }

        private string connectionString;

        public CameraatjeDbContext(string connectionString)
        {
            this.connectionString = connectionString;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
