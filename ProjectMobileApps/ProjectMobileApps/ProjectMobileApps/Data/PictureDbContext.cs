using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;

namespace ProjectMobileApps.Data
{
    public class PictureDbContext : DbContext, IPictureDbContext
    {
        public DbSet<Picture> Pictures { get; set; }

        private string connectionString;

        public PictureDbContext(string connectionString)
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
