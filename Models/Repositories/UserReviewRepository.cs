using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;

namespace DAL.Repositories
{
    public class UserReviewRepository : Repository<UserReview>, IUserReviewRepository
    {
        private readonly AppDbContext appDbContext;
        public UserReviewRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            this.appDbContext = appDbContext;
        }
    }
}
