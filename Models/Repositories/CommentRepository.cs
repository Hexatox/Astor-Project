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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly AppDbContext appDbContext;
        public CommentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Comment>> GetAllNavs()
        {
            var items = await appDbContext.Comments
                .Include(p => p.User)
                .Include(p => p.Post)
                .ToListAsync();
            return items;
        }
        // here the implementation of the interface methods in <ICommentRepository>

    }
}
