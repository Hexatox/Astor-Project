using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserReviewRepository : Repository<UserReview>, IUserReviewRepository
    {
        private readonly AppDbContext appDbContext;
        public UserReviewRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<UserReview>> GetAllNavs()
        {
            var items = await appDbContext
                
                .UserReviews
                .Include (p => p.User)
                .Include (p => p.ReviewTo)
                .ToListAsync();
            return items;
        }
    }
}
