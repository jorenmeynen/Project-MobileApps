using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Repositories
{
    class PictureRepository : IPictureRepository
    {
        public Task<int> DeletePictureAsync(Picture picture)
        {
            throw new NotImplementedException();
        }

        public Task<Picture> GetPictureAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Picture>> GetPicturesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SavePictureAsync(Picture picture)
        {
            throw new NotImplementedException();
        }
    }
}
