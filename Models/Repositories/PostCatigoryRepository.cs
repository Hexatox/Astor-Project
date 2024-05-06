using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
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
    }
}
