using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LikeRepository : Repository<Like>, ILikeRepository
    {
        private readonly AppDbContext appDbContext;
        public LikeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Like>> GetAllNavs()
        {
            var items = await appDbContext.Likes
                .Include(p => p.User)
                .Include(p => p.Post)
                .ToListAsync();
            return items;
        }
    }
}
