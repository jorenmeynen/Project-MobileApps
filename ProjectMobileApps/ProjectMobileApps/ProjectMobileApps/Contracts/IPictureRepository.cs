using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Contracts
{
    public interface IPictureRepository
    {
        Task<List<Picture>> GetPicturesAsync();

        Task<Picture> GetPictureAsync(int id);

        Task<int> SavePictureAsync(Picture picture);

        Task<int> DeletePictureAsync(Picture picture);
    }
}
