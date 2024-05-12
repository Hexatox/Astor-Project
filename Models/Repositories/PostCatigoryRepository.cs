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
    public class PostCatigoryRepository : Repository<PostCatigory>, IPostCatigoryRepository    
    {
        private readonly AppDbContext appDbContext;
        public PostCatigoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<PostCatigory>> GetAllNavs()
        {
            var items = await appDbContext.PostCatigories
                .Include(p => p.Catigory)
                .Include(p => p.Post)
                .ToListAsync()
                ;
            return items;
        }
    }
}
