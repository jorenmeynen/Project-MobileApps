using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Contracts
{
    public interface ICameraatjeRepository
    {
        Task<List<Toddler>> GetToddlersAsync();
        Task<List<Corner>> GetCornersAsync();
        Task<List<Picture>> GetPicturesAsync();

        Task<int> SavePictureAsync(Picture picture);
    }
}
