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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private readonly AppDbContext appDbContext;
        public PostRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

		public async Task<Post> GetAllByAsync(string id)
		{
			var p = await appDbContext.Posts.Include(p => p.User)
				.Include(p => p.Likes)
				.Include(p => p.Comments)
				.Include(p => p.Catigories)
				.FirstOrDefaultAsync(p => p.User.Id == id);
            return p;
		}

		public async Task<List<Post>> GetAllNavs()
        {
            var items = await appDbContext.Posts
                .Include(p => p.User)
                .Include(p => p.Likes)
                .Include(p => p.Comments)
                .Include(p => p.Catigories)
                .ToListAsync();
            return items;
        }

        public async Task<Post> GetBy(int Id)
        {
            return await appDbContext.Posts.Include(p => p.User)
                .Include(p => p.Likes)
                .Include(p => p.Comments)
                .Include(p => p.Catigories)
                .FirstOrDefaultAsync(p => p.PostId == Id);
        }

    }
}
