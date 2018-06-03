using Microsoft.EntityFrameworkCore;
using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileApps.Repositories
{
    public class CameraatjeRepository : ICameraatjeRepository
    {
        private ICameraatjeDbContext dbContext;

        public CameraatjeRepository(ICameraatjeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Toddler>> GetToddlersAsync()
        {
            return await dbContext.Toddlers.ToListAsync();
        }

        public async Task<List<Corner>> GetCornersAsync()
        {
            return await dbContext.Corners.ToListAsync();
        }

        public async Task<List<Picture>> GetPicturesAsync()
        {
            return await dbContext.Pictures.ToListAsync();
        }

        public async Task<int> SavePictureAsync(Picture picture)
        {
            if (picture.PictureId == 0)
            {
                await dbContext.Pictures.AddAsync(picture);
            }

            return await dbContext.SaveChangesAsync();
        }
    }
}
