using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMobileApps.Data
{
    public class ToddlerDbContext : DbContext, IToddlerDbContext
    {
        public DbSet<Toddler> Toddlers { get; set; }
        
    }
}
