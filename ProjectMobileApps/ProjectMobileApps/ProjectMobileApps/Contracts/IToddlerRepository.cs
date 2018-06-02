using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Contracts
{
    public interface IToddlerRepository
    {
        Task<List<Toddler>> GetToddlersAsync();

        Task<Toddler> GetToddlerAsync(int id);
    }
}
