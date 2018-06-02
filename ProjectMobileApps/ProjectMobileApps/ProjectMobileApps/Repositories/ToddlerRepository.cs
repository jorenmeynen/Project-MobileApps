using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Repositories
{
    public class ToddlerRepository : IToddlerRepository
    {
        private IToddlerDbContext dbContext;

        public ToddlerRepository(IToddlerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Toddler>> GetToddlersAsync()
        {
            throw new NotImplementedException();
        }



        public Task<Toddler> GetToddlerAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
